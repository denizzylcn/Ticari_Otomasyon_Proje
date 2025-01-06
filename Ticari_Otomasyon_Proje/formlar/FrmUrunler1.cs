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
    public partial class FrmUrunler1 : Form
    {
        public FrmUrunler1()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities3 db = new DbTicariOtomasyonEntities3();
        private void FrmUrunler1_Load(object sender, EventArgs e)
        {

        }
        void urunler()
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.URUNID,
                                           x.URUNAD,
                                           x.STOK,
                                           x.ALISFIYAT,
                                           x.SATISFIYAT,
                                           x.TBLKATEGORI.KATEGORIAD,
                                       }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            TBLURUN t = new TBLURUN();
            t.URUNAD = TxtAd.Text;
            t.STOK = short.Parse(txtStok.Text);
            t.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            t.KATEGORI = int.Parse(gridLookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ürün ekleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunler();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.URUNID,
                                           x.URUNAD,
                                           x.STOK,
                                           x.ALISFIYAT,
                                           x.SATISFIYAT,
                                           x.TBLKATEGORI.KATEGORIAD,
                                       }).ToList();
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            if (TxtID.Text != "")
            {
                int id = int.Parse(TxtID.Text);
                var x = db.TBLURUN.Find(id);
                db.TBLURUN.Remove(x);
                db.SaveChanges();
                XtraMessageBox.Show("Ürün  başarılı bir şekilde silindi", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                urunler();
            }
            else
            {
                XtraMessageBox.Show("Lütfen verileri listeledikten sonra bir satıra tıklayıp silmek istediğiniz kaydı seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                urunler();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var x = db.TBLURUN.Find(id);
            x.URUNAD = TxtAd.Text;
            x.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            x.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            x.STOK = short.Parse(txtStok.Text);
            x.KATEGORI = int.Parse(gridLookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Verileriniz başarılı bir şekilde güncellendi", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("URUNID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("URUNAD").ToString();
            txtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            txtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            txtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            gridLookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORIAD").ToString();
        }
    }
}
