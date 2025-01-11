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
    public partial class FrmMusterıLıstesı : Form
    {
        public FrmMusterıLıstesı()
        {
            InitializeComponent();
        }
        DbTicariOtomasyonEntities4 db = new DbTicariOtomasyonEntities4();

        private void btnListele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLMUSTERI
                                       select new
                                       {
                                           x.MUSTERIID,
                                           x.AD,
                                           x.SOYAD,
                                           x.IL,
                                           x.ILCE,
                                           x.TELEFON,
                                           x.TC,
                                           x.MAIL,
                                           x.ADRES,
                                       }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLMUSTERI t = new TBLMUSTERI();
            t.AD = txtAd.Text;
            t.SOYAD = txtSoyad.Text;
            t.IL = lookUpEditIl.Text;
            t.ILCE = lookUpEditIlce.Text;
            t.TELEFON = txtTelefon.Text;
            t.ADRES = txtAdres.Text;
            t.MAIL = txtMail.Text;
            t.TC = txtTC.Text;
            db.TBLMUSTERI.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Müşteri sisteme başarılı bir şekildde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void FrmMusterıLıstesı_Load(object sender, EventArgs e)
        {
            lookUpEditIl.Properties.DataSource = (from x in db.TBLILLER
                                                  select new
                                                  {
                                                      x.id,
                                                      x.sehir,
                                                  }).ToList();
        }

        
        private void lookUpEditIl_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditIl.EditValue.ToString());
            lookUpEditIlce.Properties.DataSource = (from y in db.TBLILCELER
                                       select new
                                       {
                                           y.id,
                                           y.ilce,
                                           y.sehir,
                                       }).Where(z => z.sehir == secilen).ToList();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("MUSTERIID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            txtTC.Text = gridView1.GetFocusedRowCellValue("TC").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            txtAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
            lookUpEditIl.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            lookUpEditIlce.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var x = db.TBLMUSTERI.Find(id);
            x.AD = txtAd.Text;
            x.SOYAD = txtSoyad.Text;
            x.IL = lookUpEditIl.Text;
            x.ILCE = lookUpEditIlce.Text;
            x.TELEFON = txtTelefon.Text;
            x.ADRES = txtAdres.Text;
            x.MAIL = txtMail.Text;
            x.TC = txtTC.Text;
            db.SaveChanges();

            XtraMessageBox.Show(" Verileriniz başarılı bir şekilde güncellendi.", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYeniFormdaMusterıLıstesı_Click(object sender, EventArgs e)
        {
            FrmMusterıFormLıstesı fr = new FrmMusterıFormLıstesı();
            fr.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource=(from x in db.TBLMUSTERI
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
                                     }).Where(x=>x.AD==txtAd.Text || x.IL==lookUpEditIl.Text).ToList();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                int id = int.Parse(txtID.Text);
                var x = db.TBLMUSTERI.Find(id);
                db.TBLMUSTERI.Remove(x);
                XtraMessageBox.Show("Müşteri  başarılı bir şekildde silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                XtraMessageBox.Show("Lütfen verileri listeledikten sonra bir satıra tıklayıp silmek istediğiniz kaydı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
