using Npgsql;
using NpgsqlTypes;
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
    public partial class Dodavanje_nove_biljke : Form
    {
        private string konekcija1 = String.Format("Server={0};Port={1};" +
        "User Id ={2};Password={3};Database={4};",
        "localhost", 5432, "postgres", "mata1802", "DBAplikacija");

        private NpgsqlConnection conne;
        private string sqlB;
        private NpgsqlCommand cmd1;
        public Dodavanje_nove_biljke()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            if(tBoxNazivBiljke.Text != "" && tBoxMinVlaga.Text != "" && tBoxMaxVlaga.Text != "" && tBoxMinTemp.Text != "" && tBoxMaxTemp.Text != "" && tBoxZalijevanje.Text != "" && tBoxPresadivanje.Text != "" && tBoxDohranjivanje.Text != "")
            {
                conne = new NpgsqlConnection(konekcija1);
                try
                {
                    string naziv = tBoxNazivBiljke.Text;
                    int min_vlaga = int.Parse(tBoxMinVlaga.Text);
                    int max_vlaga = int.Parse(tBoxMaxVlaga.Text);
                    int min_temperatura = int.Parse(tBoxMinTemp.Text);
                    int max_temperatura = int.Parse(tBoxMaxTemp.Text);
                    int zalijevanje = int.Parse(tBoxZalijevanje.Text);
                    int dohranjivanje = int.Parse(tBoxDohranjivanje.Text);
                    int presadivanje = int.Parse(tBoxPresadivanje.Text);

                    NpgsqlRange<int> vlagaaRange = new NpgsqlRange<int>(min_vlaga, max_vlaga);
                    NpgsqlRange<int> temperaturaRange = new NpgsqlRange<int>(min_temperatura, max_temperatura);

                    conne.Open();
                    sqlB = @"INSERT INTO Biljka (naziv, datum_sadnje, vlaga, temperatura, zalijevanje, dohranjivanje, presadivanje) VALUES (@Naziv, CURRENT_DATE, @Vlaga, @Temperatura, @Zalijevanje, @Dohranjivanje, @Presadivanje)";
                    cmd1 = new NpgsqlCommand(sqlB, conne);
                    cmd1.Parameters.AddWithValue("@Naziv", naziv);
                    cmd1.Parameters.AddWithValue("@Vlaga", vlagaaRange);
                    cmd1.Parameters.AddWithValue("@Temperatura", temperaturaRange);
                    cmd1.Parameters.AddWithValue("@Zalijevanje", zalijevanje);
                    cmd1.Parameters.AddWithValue("@Dohranjivanje", dohranjivanje);
                    cmd1.Parameters.AddWithValue("@Presadivanje", presadivanje);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Dodana je nova biljka! Savjetujemo da je zalijete!");
                    conne.Close();
                    this.Close();
                }
                catch
                {
                    conne.Close();
                    MessageBox.Show("Greška kod povezivanja!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Svi podaci moraju biti popunjeni!");
            }
        }

        private void Dodavanje_nove_biljke_Load(object sender, EventArgs e)
        {
            DateTime danas = DateTime.Now;
            string datum = danas.ToString("yyyy-MM-dd");
            tBoxDatumSadnje.Text = datum;
            tBoxDatumSadnje.Enabled = false;
        }
    }
}
