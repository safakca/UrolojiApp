using System.Windows.Forms;

namespace UrolojiApp.Fonksiyonlar
{
    public class Formlar
    {
        public void HastaGiris()
        {
            Model.frmHastaGiris frm = new Model.frmHastaGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
