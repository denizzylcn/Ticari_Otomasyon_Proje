﻿using DevExpress.XtraEditors;
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
            try
            {
                TBLURUN t = new TBLURUN();
                t.URUNAD = txtUrunAd.Text;

                // Null kontrolü ve sayıya çevirme
                if (!short.TryParse(txtStok.Text, out short stok))
                {
                    XtraMessageBox.Show("Stok değeri geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                t.STOK = stok;

                if (!decimal.TryParse(txtAlisFiyat.Text, out decimal alisFiyat))
                {
                    XtraMessageBox.Show("Alış fiyatı geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                t.ALISFIYAT = alisFiyat;

                if (!decimal.TryParse(txtSatisFiyat.Text, out decimal satisFiyat))
                {
                    XtraMessageBox.Show("Satış fiyatı geçerli bir sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                t.SATISFIYAT = satisFiyat;

                if (lookUpEdit1.EditValue == null || !int.TryParse(lookUpEdit1.EditValue.ToString(), out int kategoriId))
                {
                    XtraMessageBox.Show("Lütfen geçerli bir kategori seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                t.KATEGORI = kategoriId;

                db.TBLURUN.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Ürün ekleme işlemi başarılı bir şekilde tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*TBLURUN t = new TBLURUN();
            t.URUNAD = txtUrunAd.Text;
            t.STOK = short.Parse(txtStok.Text);
            t.ALISFIYAT = decimal.Parse(txtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(txtSatisFiyat.Text);
            t.KATEGORI = int.Parse(lookUpEdit1.EditValue.ToString());
            db.TBLURUN.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Ürün ekleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
