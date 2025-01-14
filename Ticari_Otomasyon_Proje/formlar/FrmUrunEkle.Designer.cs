using System;

namespace Ticari_Otomasyon_Proje.formlar
{
    partial class FrmUrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && db != null) // `db` veritabanı bağlamınız
            {
                db.Dispose(); // Veritabanı bağlamını serbest bırak
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunEkle));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.txtStok = new DevExpress.XtraEditors.TextEdit();
            this.txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(109, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(218, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Yeni Ürün Ekleme Paneli";
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.EditValue = "Ürün Adı";
            this.txtUrunAd.Location = new System.Drawing.Point(149, 87);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUrunAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUrunAd.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUrunAd.Properties.Appearance.Options.UseBackColor = true;
            this.txtUrunAd.Properties.Appearance.Options.UseFont = true;
            this.txtUrunAd.Properties.Appearance.Options.UseForeColor = true;
            this.txtUrunAd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtUrunAd.Size = new System.Drawing.Size(178, 28);
            this.txtUrunAd.TabIndex = 1;
            this.txtUrunAd.EditValueChanged += new System.EventHandler(this.txtUrunAd_EditValueChanged);
            // 
            // txtStok
            // 
            this.txtStok.EditValue = "Alış Fiyatı";
            this.txtStok.Location = new System.Drawing.Point(149, 143);
            this.txtStok.Name = "txtStok";
            this.txtStok.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtStok.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtStok.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtStok.Properties.Appearance.Options.UseBackColor = true;
            this.txtStok.Properties.Appearance.Options.UseFont = true;
            this.txtStok.Properties.Appearance.Options.UseForeColor = true;
            this.txtStok.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtStok.Size = new System.Drawing.Size(178, 28);
            this.txtStok.TabIndex = 2;
            // 
            // txtAlisFiyat
            // 
            this.txtAlisFiyat.EditValue = "Satış Fiyatı";
            this.txtAlisFiyat.Location = new System.Drawing.Point(149, 204);
            this.txtAlisFiyat.Name = "txtAlisFiyat";
            this.txtAlisFiyat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtAlisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAlisFiyat.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAlisFiyat.Properties.Appearance.Options.UseBackColor = true;
            this.txtAlisFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtAlisFiyat.Properties.Appearance.Options.UseForeColor = true;
            this.txtAlisFiyat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtAlisFiyat.Size = new System.Drawing.Size(178, 28);
            this.txtAlisFiyat.TabIndex = 3;
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.EditValue = "Stok Sayısı";
            this.txtSatisFiyat.Location = new System.Drawing.Point(149, 267);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtSatisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSatisFiyat.Properties.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSatisFiyat.Properties.Appearance.Options.UseBackColor = true;
            this.txtSatisFiyat.Properties.Appearance.Options.UseFont = true;
            this.txtSatisFiyat.Properties.Appearance.Options.UseForeColor = true;
            this.txtSatisFiyat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSatisFiyat.Size = new System.Drawing.Size(178, 28);
            this.txtSatisFiyat.TabIndex = 4;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(149, 330);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lookUpEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(178, 28);
            this.lookUpEdit1.TabIndex = 5;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(69, 400);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(113, 42);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnVazgec.ImageOptions.Image")));
            this.BtnVazgec.Location = new System.Drawing.Point(233, 400);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(111, 42);
            this.BtnVazgec.TabIndex = 7;
            this.BtnVazgec.Text = "Vazgeç";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // FrmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(499, 500);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.txtSatisFiyat);
            this.Controls.Add(this.txtAlisFiyat);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrunEkle";
            this.Load += new System.EventHandler(this.FrmUrunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.TextEdit txtStok;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
        private EventHandler txtUrunAd_Enter;
    }
}