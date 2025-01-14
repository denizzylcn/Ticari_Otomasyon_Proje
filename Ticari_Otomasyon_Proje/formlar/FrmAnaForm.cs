using System;
using System.Data;
using System.Linq;
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

            var musterı = (from x in db.TBLMUSTERI
                           select new
                           {
                               x.AD,
                               x.SOYAD,
                               x.TELEFON,
                           }).ToList();
            gridControl4.DataSource = musterı;
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
