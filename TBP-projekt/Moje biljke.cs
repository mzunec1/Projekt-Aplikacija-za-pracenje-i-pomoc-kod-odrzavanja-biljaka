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
using Npgsql;
using NpgsqlTypes;
using System.Security.Policy;
namespace TBP_projekt
{
    public partial class Moje_biljke : Form
    {
        private string konekcija = String.Format("Server={0};Port={1};" +
        "User Id ={2};Password={3};Database={4};",
        "localhost", 5432, "postgres", "mata1802", "DBAplikacija");

        private NpgsqlConnection conn;
        private NpgsqlConnection conn2;
        private string sql;
        private string sql2;
        private string sqlU;
        private NpgsqlCommand cmd;
        private NpgsqlCommand cmd2;
        private NpgsqlCommand cmd3;
        private DataTable dt;
        int id_selektiranog;
        public Moje_biljke()
        {
            InitializeComponent();
        }
        public void UcitajPodatkeIzBaze()
        {
            conn = new NpgsqlConnection(konekcija);
            try
            {
                conn.Open();
                sql = @"SELECT * FROM biljka ORDER BY id_biljke";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                dataGridView1.SelectionChanged += dataGridView_SelectionChanged;
                conn.Close();
            }
            catch
            {
                conn.Close();
                MessageBox.Show("Greška kod povezivanja!");
            }
        }
        private void PopuniCombo()
        {
            conn = new NpgsqlConnection(konekcija);
            try
            {
                conn.Open();
                string sql = "SELECT id_biljke, naziv FROM Biljka";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    cmbTnazivi.DataSource = dataTable;
                    cmbTnazivi.ValueMember = "id_biljke";
                    cmbTnazivi.DisplayMember = "naziv"; 
                    cmbVnazivi.DataSource = dataTable;
                    cmbVnazivi.ValueMember = "id_biljke";
                    cmbVnazivi.DisplayMember = "naziv";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom dohvaćanja podataka: " + ex.Message);
            }



        }
        private void Moje_biljke_Load(object sender, EventArgs e)
        {
            UcitajPodatkeIzBaze();
            PopuniCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dodavanje_nove_biljke novaBiljka = new Dodavanje_nove_biljke();
            novaBiljka.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            conn2 = new NpgsqlConnection(konekcija);
            try
            {
                conn2.Open();
                sql2 = @"DELETE FROM biljka WHERE id_biljke = @ID_biljke";
                cmd2 = new NpgsqlCommand(sql2, conn2);
                cmd2.Parameters.AddWithValue("@ID_biljke", id_selektiranog);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Biljka je obrisana!");
                conn2.Close();
                UcitajPodatkeIzBaze();
            }
            catch
            {
                conn2.Close();
                MessageBox.Show("Greška kod povezivanja!");
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e) 
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id_selektiranog = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_biljke"].Value);   
            }
         
        }

        private void btnUnesiTemperaturu_Click(object sender, EventArgs e)
        {
            if (tboxTemperatura != null)
            {
                conn = new NpgsqlConnection(konekcija);
                try
                {
                    int temperatura = int.Parse(tboxTemperatura.Text);
                    int id_biljke = Convert.ToInt32(cmbTnazivi.SelectedValue);
                    conn.Open();
                    sqlU = @"UPDATE radnje_biljka SET trenutna_temperatura = @Temperatura WHERE id_biljke = @biljka";
                    cmd3 = new NpgsqlCommand(sqlU, conn);
                    cmd3.Parameters.AddWithValue("@Temperatura", temperatura);
                    cmd3.Parameters.AddWithValue("@biljka", id_biljke);

                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Trenutna temperatura je zabilježena!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show($"Greška kod povezivanja: {ex.Message}!");
                }
            }
        }

        private void btnUnesiVlagu_Click(object sender, EventArgs e)
        {
            if (tboxVlaga != null)
            {
                conn = new NpgsqlConnection(konekcija);
                try
                {
                    int vlaga = int.Parse(tboxVlaga.Text);
                    int id_biljke = Convert.ToInt32(cmbVnazivi.SelectedValue);
                    conn.Open();
                    sqlU = @"UPDATE radnje_biljka SET trenutna_vlaga = @Vlaga WHERE id_biljke = @biljka";
                    cmd3 = new NpgsqlCommand(sqlU, conn);
                    cmd3.Parameters.AddWithValue("@Vlaga", vlaga);
                    cmd3.Parameters.AddWithValue("@biljka", id_biljke);

                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Trenutni postotak vlage je zabilježen!");
                    conn.Close();
                }
                catch(Exception ex) 
                {
                    conn.Close();
                    MessageBox.Show($"Greška kod povezivanja: {ex.Message}!");
                }
            }
        }
    }
}
