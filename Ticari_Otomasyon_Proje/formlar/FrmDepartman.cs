using DevExpress.XtraCharts;
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using Ticari_Otomasyon_Proje.entity;

namespace Ticari_Otomasyon_Proje.formlar
{
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            db.TBLDEPARTMAN.Load();
            bindingSource1.DataSource = db.TBLDEPARTMAN.Local;

            // Departmanlara göre personel sayılarını grupluyoruz
            var degerler = db.TBLPERSONEL
                             .OrderBy(x => x.TBLDEPARTMAN.DEPARTMANAD)
                             .GroupBy(y => y.TBLDEPARTMAN.DEPARTMANAD)
                             .Select(z => new
                             {
                                 Ad = z.Key,
                                 TOPLAM = z.Count()
                             }).ToList();

            // Eğer seri yoksa oluşturuyoruz
            if (chartControl1.Series["Departmanlar"] == null)
            {
                var series = new DevExpress.XtraCharts.Series("Departmanlar", DevExpress.XtraCharts.ViewType.Bar);
                chartControl1.Series.Add(series);
            }

            // Verileri ekliyoruz
            foreach (var x in degerler)
            {
                chartControl1.Series["Departmanlar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(x.Ad, x.TOPLAM));
            }


        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
