using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.entity;

namespace Ticari_Otomasyon_Proje.formlar
{
    public partial class Frmistatislikler : Form
    {
        public Frmistatislikler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {
            panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }



        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {
            panelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }



        private void panelControl6_Paint(object sender, PaintEventArgs e)
        {
            panelControl6.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {
            panelControl5.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl12_Paint(object sender, PaintEventArgs e)
        {
            panelControl12.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl11_Paint(object sender, PaintEventArgs e)
        {
            panelControl11.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl10_Paint(object sender, PaintEventArgs e)
        {
            panelControl10.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void panelControl9_Paint(object sender, PaintEventArgs e)
        {
            panelControl9.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void Frmistatislikler_Load(object sender, EventArgs e)
        {
            lblUrunSayisi1.Text = db.TBLURUN.Count().ToString();
            lblKategoriSayisi1.Text = db.TBLKATEGORI.Count().ToString();
            lblPersonelSayisi1.Text = db.TBLPERSONEL.Count().ToString();
            lblToplamStok.Text = db.TBLURUN.Count().ToString();
            lblEnDusukStokUrun.Text = db.TBLURUN.Where(x => x.KATEGORI == 1).Sum(y => y.STOK).ToString();
            lblKrıtıkStok.Text = db.TBLURUN.Count(x => x.KRITIKSEVIYE == true).ToString();
            lblYuksekStokUrun.Text = db.TBLURUN.OrderByDescending(x => x.STOK).Select(y => y.URUNAD).FirstOrDefault().ToString();
            lblEnYuksekFiyatlıUrun.Text = db.TBLURUN.OrderByDescending(x => x.SATISFIYAT).Select(y => y.URUNAD).FirstOrDefault().ToString();
            lblDusukFiyatlıUrun.Text = db.TBLURUN.OrderBy(x => x.SATISFIYAT).Select(y => y.URUNAD).FirstOrDefault().ToString();
        }
    }
}
