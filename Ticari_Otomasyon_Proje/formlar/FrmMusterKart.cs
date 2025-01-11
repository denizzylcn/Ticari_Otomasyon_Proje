using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.entity;

namespace Ticari_Otomasyon_Proje.formlar
{
    public partial class FrmMusterKart : Form
    {
        public FrmMusterKart()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmMusterKart_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbTicariOtomasyonDataSet1.TBLILCELER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLILCELERTableAdapter.Fill(this.dbTicariOtomasyonDataSet1.TBLILCELER);
            // TODO: Bu kod satırı 'dbTicariOtomasyonDataSet.TBLILLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLILLERTableAdapter.Fill(this.dbTicariOtomasyonDataSet.TBLILLER);
            lookUpEditil.Properties.DataSource = (from x in db.TBLILLER
                                                                   select new
                                                                   {
                                                                       x.id,
                                                                       x.sehir
                                                                   }).ToList();
        }

        // İl seçildiğinde ilçeleri yükle
        private void lookUpEditIl_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            if (int.TryParse(lookUpEditil.EditValue?.ToString(), out secilen))
            {
                lookUpEditilce.Properties.DataSource = (from y in db.TBLILCELER
                                                        select new
                                                        {
                                                            y.id,
                                                            y.ilce,
                                                            y.sehir
                                                        }).Where(z => z.sehir == secilen).ToList();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLMUSTERI t = new TBLMUSTERI();
            t.AD = txtAd.Text; // Ad bilgisi alınıyor
            t.SOYAD = TxtSoyad.Text; // Soyad bilgisi alınıyor
            t.IL = lookUpEditil.Text; // İl bilgisi alınıyor
            t.ILCE = lookUpEditilce.Text; // İlçe bilgisi alınıyor
            t.TELEFON = TxtTelefon.Text; // Telefon bilgisi alınıyor
            t.ADRES = TxtAdres.Text; // Adres bilgisi alınıyor
            t.MAIL = TxtMail.Text; // Mail bilgisi alınıyor
            t.TC = TxtTC.Text; // TC bilgisi alınıyor
            db.TBLMUSTERI.Add(t);
            db.SaveChanges(); // Değişiklikler kaydediliyor

            // Başarılı işlem mesajı
            XtraMessageBox.Show("Cari sisteme başarılı bir şekilde eklendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
