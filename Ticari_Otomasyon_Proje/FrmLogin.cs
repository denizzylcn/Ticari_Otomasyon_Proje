using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Ticari_Otomasyon_Proje.entity;

namespace Ticari_Otomasyon_Proje
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN
                        where x.KULLANICIAD == txtKullanıcıAd.Text && x.SIFRE == txtSıfre.Text
                        select x;
            if (sorgu.Any())
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
