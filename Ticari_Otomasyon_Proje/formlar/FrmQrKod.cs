using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace Ticari_Otomasyon_Proje.formlar
{
    public partial class FrmQrKod : Form
    {
        public FrmQrKod()
        {
            InitializeComponent();
        }

        private void FrmQrKod_Load(object sender, EventArgs e)
        {

        }

        private void btnQrKod_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            pictureEdit1.Image = enc.Encode(textEdit1.Text);
        }
    }
}
