using System;
using System.Windows.Forms;

namespace UrolojiApp.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj, "Yeni Kayıt Giriş",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili olan kayıt güncellenecektir\n" +
                "Güncelleme işlemini onaylıyor musunuz?", "Güncelleme İşlemi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        public DialogResult Kayit()
        {
            return MessageBox.Show("Aynı kaydı tekrar kaydetmek istiyor musunuz", "Kayıt Uyarısı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Tüm kayıtlar kalıcı olarak silinecektir\n" +
                "Silme işlemini onaylıyor musunuz?", "Silme İşlemi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt güncellenmiştir.", "Kayıt Güncelleme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        //public void Kayit(bool kayit)
        //{
        //    MessageBox.Show("Kayıt eklenmiştir.", "Kayıt Ekleme",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Information);
        //}
        public void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message,"Hata Olustu", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public DialogResult Yazdir()
        {
            return MessageBox.Show("Kaydi yazdirmak istiyor musunuz?", "Yazdirma Islemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
