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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Moje_biljke moje_Biljke = new Moje_biljke();
            moje_Biljke.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Događaji događaji = new Događaji();
            događaji.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Galerija galerija = new Galerija();
            galerija.Show();
        }
    }
}
