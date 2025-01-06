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
    public partial class FrmKasaListesi : Form
    {
        public FrmKasaListesi()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities3 db = new DbTicariOtomasyonEntities3();
        private void FrmKasaListesi_Load(object sender, EventArgs e)
        {
            var kasa_verileri = db.TBLKASA.ToList();
            gridControl1.DataSource = kasa_verileri;
        }
    }
}
