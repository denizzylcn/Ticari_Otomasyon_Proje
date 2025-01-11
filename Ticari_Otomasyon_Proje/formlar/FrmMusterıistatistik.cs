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
    public partial class FrmMusterıistatistik : Form
    {
        public FrmMusterıistatistik()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmMusterıistatistik_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbTicariOtomasyonDataSet.TBLILLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLILLERTableAdapter.Fill(this.dbTicariOtomasyonDataSet.TBLILLER);
            gridControl1.DataSource = db.TBLMUSTERI.OrderBy(x => x.IL).
                GroupBy(y => y.IL).
                Select(z => new { il = z.Key, TOPLAM = z.Count() }).ToList();
            var degerler = db.TBLMUSTERI
                     .OrderBy(x => x.IL) // İl bazında sıralama
                     .GroupBy(x => x.IL) // İl bazında gruplama
                     .Select(z => new
                     {
                         IL = z.Key,          // Gruplandırılan İl
                         TOPLAM = z.Count()  // O ildeki toplam kayıt sayısı
                     }).ToList();
            if (chartControl1.Series["iller"] == null)
            {
                DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("iller", DevExpress.XtraCharts.ViewType.Bar);
                chartControl1.Series.Add(series);
            }

            // Veri listesi kontrolü
            if (degerler == null || !degerler.Any())
            {
                MessageBox.Show("Grafik için veri yok!");
                return;
            }

            // Veri ekleme
            foreach (var x in degerler)
            {
                chartControl1.Series["iller"].Points.AddPoint(x.IL, int.Parse(x.TOPLAM.ToString()));
            }
        }
    }
}
