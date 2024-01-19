using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlTypes;

namespace TBP_projekt
{
    public partial class Galerija : Form
    {
        private string konekcija = String.Format("Server={0};Port={1};" +
        "User Id ={2};Password={3};Database={4};",
        "localhost", 5432, "postgres", "mata1802", "DBAplikacija");

        private NpgsqlConnection conn;
        private NpgsqlConnection conn2;
        private string sql;
        private string sql2;
        private NpgsqlCommand cmd;
        private NpgsqlCommand cmd2;
        private DataTable galerija;
        private byte[] BytesSlike;
        private byte[] selektirana_slika;
        public Galerija()
        {
            InitializeComponent();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Slike|*.jpg;*jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var putanja = ofd.FileName;
                pBoxSlika.Image = Image.FromFile(putanja);

                BytesSlike = File.ReadAllBytes(putanja);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            conn = new NpgsqlConnection(konekcija);
            try
            {
                conn.Open();
                sql = @"SELECT * FROM Biljka where Naziv =@Naziv";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Naziv", tBoxNaziv.Text);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        label4.Visible = true;
                        labelID.Visible = true;
                        label5.Visible = true;
                        labelDatumsadnje.Visible = true;
                        labelID.Text = reader["ID_biljke"].ToString();
                        labelDatumsadnje.Text = reader["Datum_sadnje"].ToString();

                        UcitavanjeSlika();
                    }
                    else
                    {
                        MessageBox.Show("Nije pronađena biljka s tim nazivom.");
                    }
                }

                conn.Close();

            }
            catch
            {
                conn.Close();
                MessageBox.Show("Greška kod povezivanja!");
            }
        }

        private void Galerija_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            labelID.Visible = false;
            label5.Visible = false;
            labelDatumsadnje.Visible = false;
            
        }
        private void UcitavanjeSlika()
        {
            conn = new NpgsqlConnection(konekcija);
            if(tBoxNaziv != null)
            {
                try
                {
                    conn.Open();
                    string biljka = tBoxNaziv.Text;
                    sql = @"SELECT * FROM slike s JOIN biljka b ON s.id_biljke = b.id_biljke WHERE b.naziv = @naziv";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@naziv", biljka);          
                    galerija = new DataTable();
                    galerija.Load(cmd.ExecuteReader());
                    conn.Close();
                    dgGalerija.DataSource = null;
                    dgGalerija.DataSource = galerija;
                    dgGalerija.SelectionChanged += dgGalerija_SelectionChanged;

                }
                catch(Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Greška kod povezivanja!" + ex.Message);
                }
            }
            
        }
        private void dgGalerija_SelectionChanged(object sender, EventArgs e)
        {
            if (dgGalerija.SelectedRows.Count > 0)
            {
                selektirana_slika = (byte[])dgGalerija.SelectedRows[0].Cells["slika"].Value;
                try
                {
                    using (MemoryStream ms = new MemoryStream(selektirana_slika))
                    {
                        Image slika = Image.FromStream(ms);
                        pBoxPrikazSlike.SizeMode = PictureBoxSizeMode.Zoom;
                        pBoxPrikazSlike.Image = slika;
                    }
                }
                catch
                {
                    MessageBox.Show("Greška pri prikazu slike");
                }
            }
        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            conn2 = new NpgsqlConnection(konekcija);
            if (BytesSlike != null)
            {
                try
                {
                    conn2.Open();
                    sql2 = @"INSERT INTO Slike (id_biljke, slika, opis) VALUES (@id_biljke, @slika, @opis)";
                    cmd2 = new NpgsqlCommand(sql2, conn2);
                    string id = labelID.Text;
                    string opis = tBoxOpis.Text;
                    if (int.TryParse(id, out int idBiljke))
                    {
                        cmd2.Parameters.AddWithValue("@id_biljke", idBiljke);
                    }
                    else
                    {
                        MessageBox.Show("Neuspješno čitanje ID-a iz labele.");
                        return;
                    }
                    cmd2.Parameters.AddWithValue("@slika", BytesSlike);
                    cmd2.Parameters.AddWithValue("@opis", tBoxOpis.Text);
                    cmd2.ExecuteNonQuery();
                    conn2.Close();
                    MessageBox.Show("Slika je dodana!");

                }
                catch 
                {
                    MessageBox.Show("Greška kod povezivanja!");
                }
            }

        }

        private void btnZalijevanje_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
