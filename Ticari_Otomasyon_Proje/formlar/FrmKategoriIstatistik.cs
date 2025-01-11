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
    public partial class FrmKategoriIstatistik : Form
    {
        public FrmKategoriIstatistik()
        {
            InitializeComponent();
        }

        private void lblKategoriSayisi_Click(object sender, EventArgs e)
        {

        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmKategoriIstatistik_Load(object sender, EventArgs e)
        {
           
            gridControl1.DataSource = (from x in db.TBLKATEGORI
                                       select new
                                       {
                                           x.ID,
                                           x.KATEGORIAD,
                                       }).ToList();

            // "Kategori" serisini oluştur ve Chart Control'e ekle
            

            // Diğer işlemler
            lblKategoriSayisi1.Text = db.TBLKATEGORI.Count().ToString();
            lblSonEklenenKategori.Text = db.TBLKATEGORI
                .OrderByDescending(x => x.ID)
                .Select(y => y.KATEGORIAD)
                .FirstOrDefault()
                .ToString();

            var deger = db.TBLURUN
                .GroupBy(x => x.KATEGORI)
                .OrderByDescending(z => z.Count())
                .Select(y => new { y.Key })
                .FirstOrDefault();

            lblEnFazlaUrunuKategori.Text = db.TBLKATEGORI
                .Where(x => x.ID == deger.Key)
                .Select(z => z.KATEGORIAD)
                .FirstOrDefault()
                .ToString();

            var degerler = db.TBLURUN.ToList();
            foreach(var x in degerler)
            {
                chartControl1.Series["ürün -stok"].Points.AddPoint(x.URUNAD, short.Parse(x.STOK.ToString()));
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {
            panelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {
            panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void lblKategoriSayisi1_Click(object sender, EventArgs e)
        {

        }
    }
}
