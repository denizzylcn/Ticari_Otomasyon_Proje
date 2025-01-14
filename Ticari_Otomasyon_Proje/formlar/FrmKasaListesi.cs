using System;
using System.Linq;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.entity;

namespace Ticari_Otomasyon_Proje.formlar
{
    public partial class FrmKasaListesi : Form
    {
        public FrmKasaListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmKasaListesi_Load(object sender, EventArgs e)
        {
            var kasa_verileri = db.TBLKASA.ToList();
            gridControl1.DataSource = kasa_verileri;
        }
    }
}
