using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            var degerler = db.TBLPERSONEL.OrderBy(x => x.TBLDEPARTMAN.DEPARTMANAD).GroupBy(y => y.TBLDEPARTMAN.DEPARTMANAD).
                Select(z => new { Ad = z.Key, TOPLAM = z.Count() }).ToList();
            foreach(var x in degerler)
            {
                chartControl2.Series["Departmanlar"].Points.AddPoint(x.Ad, short.Parse(x.TOPLAM.ToString()));
            }
            foreach (var x in degerler)
            {
                chartControl1.Series["Departmanlar"].Points.AddPoint(x.Ad, short.Parse(x.TOPLAM.ToString()));
            }
            db.TBLDEPARTMAN.Load();
            bindingSource1.DataSource = db.TBLDEPARTMAN.Local;
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
