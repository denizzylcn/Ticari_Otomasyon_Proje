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
using static DevExpress.Utils.HashCodeHelper.Blob;

namespace Ticari_Otomasyon_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        formlar.FrmAnaForm frm1;
        private void btnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new formlar.FrmAnaForm
                {
                    MdiParent = this, // Form1'i MDI Parent olarak ayarla
                    FormBorderStyle = FormBorderStyle.None, // Kenarlıkları kaldır
                    Dock = DockStyle.Fill // Formu tam ekran yap
                };
                frm1.Show(); // Formu göster
            }
            else
            {
                frm1.BringToFront(); // Zaten açıksa öne getir
            }
        }

        private void btnKategorıLıstesı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmKategoriler1 frm = new formlar.FrmKategoriler1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnYeniKategorı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmKategoriEkle frm = new formlar.FrmKategoriEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKategorıIstatıstık_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmKategoriIstatistik frm = new formlar.FrmKategoriIstatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnUrunLıstesı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmUrunler1 frm = new formlar.FrmUrunler1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnYenıUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmUrunEkle frm = new formlar.FrmUrunEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnUrunIstatıslıklerı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.Frmistatislikler frm = new formlar.Frmistatislikler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmQrKod frm = new formlar.FrmQrKod();
            frm.Show();
        }

        private void btnMusterıLıstesı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMusterıLıstesı frm = new formlar.FrmMusterıLıstesı();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnYenıMusterı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMusterKart frm = new formlar.FrmMusterKart();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnMusterıIstatıstık_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMusterıistatistik frm = new formlar.FrmMusterıistatistik();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMusterıHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMusterıHareket frm = new formlar.FrmMusterıHareket();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmPersonel frm = new formlar.FrmPersonel();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmDepartman frm = new formlar.FrmDepartman();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmNotlar frm = new formlar.FrmNotlar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnYeniNot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmYeniNot frm = new formlar.FrmYeniNot();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btnYardım_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Değerli kullanıcı, ticari otomasyon sistemimizle ilgili yaşadığınız her türlü sorun için aşağıdaki kanallardan bize ulaşabilirsiniz:\n\n" +
                       "- E-posta: destek@ticariotomasyon.com\n" +
                       "- Telefon: +90 (312) 123 45 67\n" +
                       "- Çalışma Saatlerimiz: Hafta içi 09:00 - 18:00\n\n" +
                       "Ayrıca, sıkça sorulan sorular (SSS) ve kullanıcı rehberine ana menüdeki 'Yardım' sekmesinden ulaşabilirsiniz.\n\n" +
                       "Size en hızlı şekilde yardımcı olabilmek için buradayız. Teşekkür ederiz!",
                       "Yardım ve Destek", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

