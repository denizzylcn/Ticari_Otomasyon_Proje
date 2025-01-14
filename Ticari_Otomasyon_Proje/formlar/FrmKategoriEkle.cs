using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.entity;

namespace Ticari_Otomasyon_Proje.formlar
{
    public partial class FrmKategoriEkle : Form
    {
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();

        public FrmKategoriEkle()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.KATEGORIAD = txtKategoriAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Kategori Ekleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Hata, lütfen kategori adını boş bırakmayınız veya 20 karakterden uzun kategori adı girişi yapmayınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKategoriEkle_Load(object sender, EventArgs e)
        {

        }

    }
}
