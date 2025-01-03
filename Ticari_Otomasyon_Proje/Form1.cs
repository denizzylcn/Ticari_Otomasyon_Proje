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

namespace Ticari_Otomasyon_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKategoriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnUrunistatislikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmIstatistikler frm = new formlar.FrmIstatistikler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
