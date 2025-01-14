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
            if (string.IsNullOrWhiteSpace(TxtTutar.Text) || !decimal.TryParse(TxtTutar.Text, out decimal tutar))
            {
                XtraMessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtTarih.Text) || !DateTime.TryParse(TxtTarih.Text, out DateTime tarih))
            {
                XtraMessageBox.Show("Lütfen geçerli bir tarih giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Gider nesnesini oluşturma ve ekleme
                TBLGIDERLER t = new TBLGIDERLER
                {
                    ACIKLAMA = TxtAciklama.Text,
                    TUTAR = tutar,
                    TARIH = tarih
                };
                db.TBLGIDERLER.Add(t);
                db.SaveChanges();

                // Kasa kaydını oluşturma ve ekleme
                TBLKASA t2 = new TBLKASA
                {
                    TUTAR = tutar,
                    ACIKLAMA = TxtAciklama.Text,
                    TARIH = tarih,
                    TUR = "Çıkış"
                };
                db.TBLKASA.Add(t2);
                db.SaveChanges();

                XtraMessageBox.Show("Gider sisteme başarılı bir şekilde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Hata: {ex.InnerException?.Message ?? ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btniptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
    }

