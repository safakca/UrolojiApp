using System;
using System.Drawing;
using System.Windows.Forms;
using UrolojiApp.Fonksiyonlar;

namespace UrolojiApp
{
    public partial class frmAnaSayfa : Form
    {
        Formlar f = new Formlar();

        public frmAnaSayfa()
        {
            InitializeComponent();
        }
        

        private void btnBir_Click(object sender, EventArgs e)
        {
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            gbSol.ForeColor = Color.Green;
            gbSol.Text = "Bobrek";

        }

        private void btnIki_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
            gbSol.ForeColor = Color.Maroon;
            gbSol.Text = "Bilgi Girisi";

        }

        private void btnUc_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
            gbSol.ForeColor = Color.DarkBlue;
            gbSol.Text = "Uc";
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            f.HastaGiris();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
