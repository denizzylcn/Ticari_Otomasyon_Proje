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
    public partial class FrmMusterıHareket : Form
    {
        public FrmMusterıHareket()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities3 db = new DbTicariOtomasyonEntities3();
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {
            panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {
            panelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {
            panelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void FrmMusterıHareket_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLMUSTERIHAREKET
                                       select new
                                       {
                                           x.SATISID,
                                           x.TBLURUN.URUNAD,
                                           Musterı = x.TBLMUSTERI.AD + " " + x.TBLMUSTERI.SOYAD,
                                           Personel = x.TBLPERSONEL.PERSONELAD + " " + x.TBLPERSONEL.PERSONELSOYAD,
                                           x.TARIH,
                                           x.BIRIMFIYAT,
                                           x.ADET,
                                           x.TOPLAM
                                       }).ToList();
            lblToplamSatis.Text = db.TBLMUSTERIHAREKET.Count().ToString();
            DateTime bugun = DateTime.Today;

            // Bugünkü satış sayısını hesapla
            lblBugunkuSatis.Text = db.TBLMUSTERIHAREKET
                                    .Where(x => x.TARIH == bugun)
                                    .Count()
                                    .ToString();

            // En fazla satılan ürün
            var deger = db.TBLMUSTERIHAREKET
                          .GroupBy(x => x.URUN)
                          .OrderByDescending(z => z.Count())
                          .Select(y => y.Key)
                          .FirstOrDefault();
            lblEnFazlaSatılanUrun.Text = db.TBLURUN
                                           .Where(x => x.URUNID == deger)
                                           .Select(x => x.URUNAD)
                                           .FirstOrDefault()
                                           .ToString();

            // En fazla işlem yapılan cari
            var deger2 = db.TBLMUSTERIHAREKET
                           .GroupBy(x => x.MUSTERIID)
                           .OrderByDescending(z => z.Count())
                           .Select(y => y.Key)
                           .FirstOrDefault();
            lblMusteri.Text = db.TBLMUSTERI
                            .Where(x => x.MUSTERIID == deger2)
                            .Select(y => y.AD + " " + y.SOYAD)
                            .FirstOrDefault()
                            .ToString();

        }
    }
}
