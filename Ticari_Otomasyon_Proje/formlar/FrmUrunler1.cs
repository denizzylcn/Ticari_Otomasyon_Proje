﻿using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
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
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();

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
        private void FrmUrunler1_Load(object sender, EventArgs e)
        {

            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.KATEGORIAD,
                                                 }).ToList();
            // TODO: Bu kod satırı 'dbTicariOtomasyonDataSet2.TBLKATEGORI' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tBLKATEGORITableAdapter.Fill(this.dbTicariOtomasyonDataSet2.TBLKATEGORI);
            urunler();
        }
        

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            TBLURUN t = new TBLURUN();
            t.URUNAD = TxtAd.Text;
            t.STOK = short.Parse(txtStok.Text);
            t.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            t.KATEGORI = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ürün ekleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunler();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            urunler();
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
            x.KATEGORI = int.Parse(lookUpEdit1.EditValue.ToString());
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
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("KATEGORIAD").ToString();
        }
    }
}
