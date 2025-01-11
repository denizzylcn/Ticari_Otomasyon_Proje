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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            var urun_stok = from x in db.TBLURUN
                            select new
                            {
                                x.URUNAD,
                                x.STOK,
                            };
            gridUrunStok.DataSource = urun_stok.ToList();

            var son5astis = from x in db.TBLMUSTERIHAREKET
                            select new
                            {
                                x.TBLURUN.URUNAD,
                                x.ADET,
                                x.TOPLAM,
                                x.SATISID,
                            };
            gridSon5Satis.DataSource = son5astis.OrderByDescending(x => x.SATISID).Take(5).ToList();
            gridView2.Columns["SATIS ID"].Visible = false;


            DateTime bugun = DateTime.Today;
            var bugunyapilacaklar = (from x in db.TBLNOTLAR
                                     select new
                                     {
                                         x.BASLIK,
                                         x.SAAT,
                                         x.TARIH,
                                     }).Where(x => x.TARIH == bugun).ToList();
            gridbugunyapilacakar.DataSource = bugunyapilacaklar;
            gridView1.Columns["TARIH"].Visible = false;
        }
    }
}
