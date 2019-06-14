using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using UrolojiApp.Fonksiyonlar;

namespace UrolojiApp.Model
{
    public partial class frmHastaGiris : Form
    {
        UrolojiDbDataContextDataContext db = new UrolojiDbDataContextDataContext();
        Mesajlar m = new Mesajlar();
        private bool _edit = false;

        public frmHastaGiris()
        {
            InitializeComponent();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                splitContainer1.Panel2Collapsed = false;
                btnCollapse.Text = "GIZLE";
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
                btnCollapse.Text = "GOSTER";
            }
        }
        void Temizle()
        {
            foreach (Control ct in tabPage1.Controls)
            {
                if (ct is TextBox || ct is ComboBox) ct.Text = "";
            }
        }
        void YeniKaydet()
        {
            bHastaBilgileri hb = new bHastaBilgileri();
            {
                hb.HastaAdi = txtHastaAdi.Text;
                hb.HastaSoyadi = txtHastaSoyad.Text;
                hb.OperasyonTarihi = DateTime.Parse(dateOpTarih.Text);  //parse ettik
                hb.OperasyonTuru = txtOpTuru.Text;
                hb.ProtokolNo = txtProtokolNo.Text;
                hb.Takip = int.Parse(txtTakip.Text);
                hb.Anah = int.Parse(txtAnah.Text);

            }
            db.bHastaBilgileris.InsertOnSubmit(hb);
            db.SubmitChanges();
            m.YeniKayit("Kayit Islemi Yapildi");
            Temizle();
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnoptur = new Button(); //sanal bir buton olusturuldu
            btnoptur.Size = new Size(25, txtOpTuru.ClientSize.Height + 2);
            btnoptur.Location = new Point(txtOpTuru.ClientSize.Width - btnoptur.Width, -1);
            btnoptur.Cursor = Cursors.Default;
            txtOpTuru.Controls.Add(btnoptur);
            SendMessage(txtOpTuru.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnoptur.Width << 16));
            btnoptur.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnoptur.Click += btnoptur_Click;
        }

        private void btnoptur_Click(object sender, EventArgs e)
        {
            frmOpTuru frm = new frmOpTuru();
            frm.ShowDialog();
        }

        [DllImport("user32.dll")]

        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnFormKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void frmHastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
