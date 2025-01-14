using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.entity;

namespace Ticari_Otomasyon_Proje.formlar
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            db.TBLPERSONEL.Load();
            bindingSource1.DataSource = db.TBLPERSONEL.Local;
            repositoryItemLookUpEdit4.DataSource = (from x in db.TBLDEPARTMAN
                                                    select new
                                                    {
                                                        x.ID,
                                                        x.DEPARTMANAD,
                                                    }).ToList();
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
    }
}
