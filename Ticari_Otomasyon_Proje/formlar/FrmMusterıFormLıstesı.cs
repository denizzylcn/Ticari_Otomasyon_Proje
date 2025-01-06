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
    public partial class FrmMusterıFormLıstesı : Form
    {
        public FrmMusterıFormLıstesı()
        {
            InitializeComponent();
        }

        DbTicariOtomasyonEntities3 db = new DbTicariOtomasyonEntities3();
        private void FrmMusterıFormLıstesı_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLMUSTERI
                                       select new
                                       {
                                           x.MUSTERIID,
                                           x.AD,
                                           x.SOYAD,
                                           x.IL,
                                           x.ILCE,
                                           x.ADRES,
                                           x.MAIL,
                                           x.TC,
                                           x.TELEFON,
                                       }).ToList();
        }
    }
}
