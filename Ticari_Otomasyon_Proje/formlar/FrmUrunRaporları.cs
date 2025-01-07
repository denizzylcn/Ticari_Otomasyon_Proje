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
    public partial class FrmUrunRaporları : Form
    {
        public FrmUrunRaporları()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities3 db = new DbTicariOtomasyonEntities3();
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
                                           x.TBLKATEGORI.KATEGORIAD
                                       }).ToList();
        }
        private void FrmUrunRaporları_Load(object sender, EventArgs e)
        {
            urunler();
        }

        private void btnPdfRaporu_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Pdf";
            gridControl1.ExportToPdf(path);
        }
    }
}
