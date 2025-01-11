using DevExpress.XtraEditors;
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
    public partial class FrmYeniNot : Form
    {
        public FrmYeniNot()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void FrmYeniNot_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLNOTLAR t = new TBLNOTLAR();
            t.BASLIK = TxtBaslik.Text;
            t.TARIH = DateTime.Parse(txtTarih.Text);
            t.SAAT = TimeSpan.Parse(txtSaat.Text);
            t.ICERIK = Txticerik.Text;
            db.TBLNOTLAR.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Not bilgisi sisteme kaydedildi ", "Bilgi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
