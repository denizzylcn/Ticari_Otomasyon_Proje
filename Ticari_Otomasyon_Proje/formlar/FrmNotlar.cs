using System;
using System.Linq;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.entity;

namespace Ticari_Otomasyon_Proje.formlar
{
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            Notlar.DataSource = db.TBLNOTLAR.ToList();
        }
    }
}
