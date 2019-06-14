using System;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using UrolojiApp.Fonksiyonlar;


namespace UrolojiApp.Model
{
    public partial class frmOpTuru : Form
    {
        UrolojiDbDataContextDataContext db = new UrolojiDbDataContextDataContext();
        Mesajlar m = new Mesajlar();

        public frmOpTuru()
        {
            InitializeComponent();
        }

        void Listele()
        {
            clbListe.Items.Clear();
            var lst = (from s in db.bOpTurus
                       select new
                       {
                           s.Id,
                           s.OpTuru
                       }).Distinct().OrderByDescending(x => x.Id);
            foreach (var i in lst)
            {
                clbListe.Items.Add(i.OpTuru);
            }
        }


        void YeniKaydet()
        {
            try
            {
                bOpTuru op = new bOpTuru();
                op.OpTuru = txtOpTuru.Text;
                db.bOpTurus.InsertOnSubmit(op); //sanal bir tabloda calisiyor gibi submitOnChanged db e kalıcı kaydeder
                db.SubmitChanges();  
                Listele();
            }
            

            catch (Exception e)
            {

                m.Hata(e);
            }

        }

        private void frmOpTuru_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }
    }
}
