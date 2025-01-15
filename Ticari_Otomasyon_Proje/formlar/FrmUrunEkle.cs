using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.entity;

namespace Ticari_Otomasyon_Proje.formlar
{
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.KATEGORIAD,
                                                 }).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
                TBLURUN t = new TBLURUN();
                t.URUNAD = txtUrunAd.Text;
                t.STOK = short.Parse(txtStok.Text);
                t.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
                t.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
                t.KATEGORI = int.Parse(lookUpEdit1.EditValue.ToString());
                db.TBLURUN.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Ürün ekleme işlemi başarılı bir şekilde tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            
               
          
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
