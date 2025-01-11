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
    public partial class FrmSiparisler : Form
    { 
        public FrmSiparisler()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();
        private void BtnSiparisleriListele_Click(object sender, EventArgs e)
        {
            
        }
        
        private void FrmSiparisler_Load(object sender, EventArgs e)
        {

        }
    }
}
