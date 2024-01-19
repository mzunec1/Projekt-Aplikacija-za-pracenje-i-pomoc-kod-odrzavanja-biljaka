using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBP_projekt
{
    public partial class Događaji : Form
    {
        private string konekcija = String.Format("Server={0};Port={1};" +
        "User Id ={2};Password={3};Database={4};",
        "localhost", 5432, "postgres", "mata1802", "DBAplikacija");

        private NpgsqlConnection conn; 
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        int id_selektiranog;
        public Događaji()
        {
            InitializeComponent();
        }

        private void Događaji_Load(object sender, EventArgs e)
        {
            tBoxDatum.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            tBoxDatum.Enabled = false;
            List<string> radnje = new List<string>();
            radnje.Add("Zalijevanje");
            radnje.Add("Presađivanje");
            radnje.Add("Dohranjivanje");

            cmbRadnje.DataSource = radnje;
            conn = new NpgsqlConnection(konekcija);
            try
            {
                conn.Open();
                sql = @"SELECT * FROM Radnje_biljka ORDER BY id_biljke";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                dataGridView1.SelectionChanged += DatagridView1_SelectionChanged;
            }
            catch
            {
                conn.Close();
                MessageBox.Show("Greška kod povezivanja!");
            }

            Zalijevanje_datagrid();
            Dohranjivanje_datagrid();
            Presadivanje_datagrid();


        }
        private void Zalijevanje_datagrid()
        {   
            try
            {
                conn.Open();
                sql = @"SELECT b.ID_biljke, b.Naziv, rb.Zadnje_zalijevanje, rb.Zadnje_zalijevanje + b.Zalijevanje AS iduce_zalijevanje FROM Biljka b JOIN Radnje_biljka rb ON b.ID_biljke = rb.ID_biljke WHERE (rb.Zadnje_zalijevanje + b.Zalijevanje) >= CURRENT_DATE ORDER BY iduce_zalijevanje;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgZalijevanje.DataSource = null;
                dgZalijevanje.DataSource = dt;
            }
            catch
            {
                conn.Close();
                MessageBox.Show("Greška kod povezivanja!");
            }
        }

        private void Dohranjivanje_datagrid()
        {
            try
            {
                conn.Open();
                sql = @"SELECT b.ID_biljke, b.Naziv, rb.Zadnje_dohranjivanje, rb.Zadnje_dohranjivanje + b.Dohranjivanje AS iduce_dohranjivanje FROM Biljka b JOIN Radnje_biljka rb ON b.ID_biljke = rb.ID_biljke WHERE (rb.Zadnje_dohranjivanje + b.Dohranjivanje) >= CURRENT_DATE ORDER BY iduce_dohranjivanje;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgDohranjivanje.DataSource = null;
                dgDohranjivanje.DataSource = dt;
            }
            catch
            {
                conn.Close();
                MessageBox.Show("Greška kod povezivanja!");
            }

        }
        private void Presadivanje_datagrid()
        {
            try
            {
                conn.Open();
                sql = @"SELECT b.ID_biljke, b.Naziv, rb.Zadnje_presadivanje, rb.Zadnje_presadivanje + b.Presadivanje AS iduce_presadivanje FROM Biljka b JOIN Radnje_biljka rb ON b.ID_biljke = rb.ID_biljke WHERE (rb.Zadnje_presadivanje + b.Presadivanje) >= CURRENT_DATE ORDER BY iduce_presadivanje;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgPresadivanje.DataSource = null;
                dgPresadivanje.DataSource = dt;
            }
            catch
            {
                conn.Close();
                MessageBox.Show("Greška kod povezivanja!");
            }
        }
        private void DatagridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                id_selektiranog = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_biljke"].Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(cmbRadnje.SelectedIndex == 0)
            {
                Zalijevanje();
            }
            else if(cmbRadnje.SelectedIndex == 1)
            {
                Presađivanje();
            }
            else if(cmbRadnje.SelectedIndex == 2)
            {
                Dohranjivanje();
            }
        }
        private void Zalijevanje()
        {
            var opis = tbOpis.Text;
            conn = new NpgsqlConnection(konekcija);
            try
            {
                conn.Open();
                sql = @"INSERT INTO Zalijevanje (ID_biljke, Datum_zalijevanja, Opis) VALUES (@ID_biljke, CURRENT_DATE, @Opis)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_biljke", id_selektiranog);
                cmd.Parameters.AddWithValue("@Opis", opis);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Zapis o zalijevanju je dodan!");
            }
            catch
            {
                conn.Close();
                MessageBox.Show("Greška kod povezivanja!");
            }

        }
        private void Presađivanje()
        {
            conn = new NpgsqlConnection(konekcija);
            try
            {
                var opis = tbOpis.Text;
                conn.Open();
                sql = @"INSERT INTO Presadivanje (ID_biljke, Datum_presadivanja, Opis) VALUES (@ID_biljke, CURRENT_DATE, @Opis)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_biljke", id_selektiranog);
                cmd.Parameters.AddWithValue("@Opis", opis);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Zapis o presađivanju je dodan!");
            }
            catch
            {
                conn.Close();
                MessageBox.Show("Greška kod povezivanja!");
            }
        }
        private void Dohranjivanje()
        {
            conn = new NpgsqlConnection(konekcija);
            try
            {
                var opis = tbOpis.Text;
                conn.Open();
                sql = @"INSERT INTO Dohranjivanje (ID_biljke, Datum_dohranjivanja, Opis) VALUES (@ID_biljke, CURRENT_DATE, @Opis)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_biljke", id_selektiranog);
                cmd.Parameters.AddWithValue("@Opis", opis);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Zapis o dohranjivanju je dodan!");
                Galerija podsjetnik = new Galerija();
            }
            catch
            {
                conn.Close();
                MessageBox.Show("Greška kod povezivanja!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
