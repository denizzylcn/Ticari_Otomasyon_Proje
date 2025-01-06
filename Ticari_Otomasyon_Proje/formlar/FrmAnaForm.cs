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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities3 db = new DbTicariOtomasyonEntities3();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            var urun_stok = from x in db.TBLURUN
                            select new
                            {
                                x.URUNAD,
                                x.STOK,
                            };
            gridUrunStok.DataSource = urun_stok.ToList();
        }
    }
}
