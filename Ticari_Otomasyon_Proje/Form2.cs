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

        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();

        private void Form2_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
        }

        // OpenForm metodu
        private void OpenForm<T>() where T : Form, new()
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is T)
                {
                    form.BringToFront();
                    return;
                }
            }

            T newForm = new T
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            newForm.Show();
        }

        // ItemClick metotları
        private void BtnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmKategoriler1>();
        }

        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmKategoriEkle>();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmUrunler1>();
        }

        private void BtnKategoriIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmKategoriIstatistik>();
        }

        private void btnMusterıLıstesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmMusterıLıstesı>();
        }

        private void btnYeniMusterı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmMusterKart>();
        }

        private void BtnMusterıIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmMusterıistatistik>();
        }

        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmNotlar>();
        }

        private void btnKasaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmKasaListesi>();
        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmGider>();
        }

        private void btnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmYeniNot>();
        }

        private void btnQr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmQrKod>();
        }

        private void btnUrunRaporları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmUrunRaporları>();
        }

        private void BtnPersonelLıstesı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmPersonel>();
        }

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<formlar.FrmDepartman>();
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
            XtraMessageBox.Show(
                "Projede alacağınız her türlü hata için destek mail adresi: testQgmail.com. " +
                "Bunun dışında bize +90 (123) 456 78 90 numaralı telefondan da ulaşabilirsiniz. " +
                "WhatsApp üzerinden sorularınızı bize iletirseniz en hızlı şekilde geri dönüş sağlanacaktır.",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmUrunEkle frm =new formlar.FrmUrunEkle();
            
            frm.Show();
        }

        private void btnMusterıHareketlerı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMusterıHareket frm = new formlar.FrmMusterıHareket();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

