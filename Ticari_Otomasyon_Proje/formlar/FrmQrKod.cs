using MessagingToolkit.QRCode.Codec;
using System;
using System.Windows.Forms;

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
