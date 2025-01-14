using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.entity;

namespace Ticari_Otomasyon_Proje.formlar
{
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLGIDERLER t = new TBLGIDERLER();
            t.ACIKLAMA = TxtAciklama.Text; // Açıklama text alanından alınır
            t.TUTAR = decimal.Parse(TxtTutar.Text); // Tutar text alanı decimal'a dönüştürülerek alınır
            t.TARIH = DateTime.Parse(TxtTarih.Text); // Tarih text alanından alınır ve DateTime olarak dönüştürülür

            // Yeni gider nesnesini veritabanına ekleme
            db.TBLGIDERLER.Add(t);

            // Değişiklikleri kaydetme
            db.SaveChanges();

            TBLKASA t2 = new TBLKASA();
            t2.TUTAR = decimal.Parse(TxtTutar.Text);
            t2.ACIKLAMA = TxtAciklama.Text;
            t2.TARIH = DateTime.Parse(TxtTarih.Text);
            t2.TUR = "Çıkış";
            db.TBLKASA.Add(t2);
            db.SaveChanges();

            // Başarılı mesajı gösterme
            XtraMessageBox.Show("Gider sisteme başarılı bir şekilde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmGider_Load(object sender, EventArgs e)
        {

        }
    }
}
