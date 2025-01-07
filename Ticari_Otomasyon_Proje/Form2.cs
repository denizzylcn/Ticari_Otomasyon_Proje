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
using Ticari_Otomasyon_Proje.formlar;

namespace Ticari_Otomasyon_Proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        DbTicariOtomasyonEntities3 db = new DbTicariOtomasyonEntities3();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            
        }

        private void BtnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmKategoriler1 frm = new formlar.FrmKategoriler1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmKategoriEkle fr = new formlar.FrmKategoriEkle();
            fr.Show();
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            formlar.FrmUrunEkle fr = new formlar.FrmUrunEkle();
            fr.Show();
        }

        private void BtnKategoriIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmKategoriIstatistik frm = new formlar.FrmKategoriIstatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMusterıLıstesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMusterıLıstesı fr = new formlar.FrmMusterıLıstesı();
            
            fr.Show();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmUrunler1 frm = new formlar.FrmUrunler1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnUrunistatislikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.Frmistatislikler frm = new formlar.Frmistatislikler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnYeniMusterı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMusterKart fr = new formlar.FrmMusterKart();
            fr.Show();
        }

        private void BtnMusterıIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMusterıistatistik frm = new formlar.FrmMusterıistatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmNotlar frm = new formlar.FrmNotlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKasaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmKasaListesi frm = new formlar.FrmKasaListesi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmGider frm = new formlar.FrmGider();
            frm.Show();
        }

        private void btnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmYeniNot frm = new formlar.FrmYeniNot();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnYardım_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show( "Projede alacağınız her türlü hata için destek mail adresi: testQgmail.com. " +
      "Bunun dışında bize +90 (123) 456 78 90 numaralı telefondan da ulaşabilirsiniz. " +
      "WhatsApp üzerinden sorularınızı bize iletirseniz en hızlı şekilde geri dönüş sağlanacaktır.",
      "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmQrKod frm = new formlar.FrmQrKod();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnUrunRaporları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
