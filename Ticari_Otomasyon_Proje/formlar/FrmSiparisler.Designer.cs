namespace Ticari_Otomasyon_Proje.formlar
{
    partial class FrmSiparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparisler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnSiparisEkle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.BtnSiparisGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSiparisSıl = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSiparisleriListele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(429, 438);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textEdit4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.BtnSiparisEkle);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.BtnSiparisGuncelle);
            this.groupControl1.Controls.Add(this.BtnSiparisSıl);
            this.groupControl1.Controls.Add(this.BtnSiparisleriListele);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(438, 21);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(413, 438);
            this.groupControl1.TabIndex = 4;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(109, 180);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(125, 22);
            this.textEdit4.TabIndex = 15;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 182);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 18);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Toplam Tutar:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(109, 148);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(125, 22);
            this.textEdit1.TabIndex = 12;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(109, 112);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(125, 22);
            this.textEdit2.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 116);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 18);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Sipariş ID:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 18);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Sipariş Tarihi:";
            // 
            // BtnSiparisEkle
            // 
            this.BtnSiparisEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnSiparisEkle.Appearance.Options.UseFont = true;
            this.BtnSiparisEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSiparisEkle.ImageOptions.Image")));
            this.BtnSiparisEkle.Location = new System.Drawing.Point(228, 276);
            this.BtnSiparisEkle.Name = "BtnSiparisEkle";
            this.BtnSiparisEkle.Size = new System.Drawing.Size(132, 41);
            this.BtnSiparisEkle.TabIndex = 8;
            this.BtnSiparisEkle.Text = "Ekle";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(109, 77);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(125, 22);
            this.TxtAd.TabIndex = 7;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(109, 41);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(125, 22);
            this.TxtID.TabIndex = 6;
            // 
            // BtnSiparisGuncelle
            // 
            this.BtnSiparisGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnSiparisGuncelle.Appearance.Options.UseFont = true;
            this.BtnSiparisGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSiparisGuncelle.ImageOptions.Image")));
            this.BtnSiparisGuncelle.Location = new System.Drawing.Point(228, 366);
            this.BtnSiparisGuncelle.Name = "BtnSiparisGuncelle";
            this.BtnSiparisGuncelle.Size = new System.Drawing.Size(132, 41);
            this.BtnSiparisGuncelle.TabIndex = 5;
            this.BtnSiparisGuncelle.Text = "Güncelle";
            // 
            // BtnSiparisSıl
            // 
            this.BtnSiparisSıl.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnSiparisSıl.Appearance.Options.UseFont = true;
            this.BtnSiparisSıl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSiparisSıl.ImageOptions.Image")));
            this.BtnSiparisSıl.Location = new System.Drawing.Point(228, 322);
            this.BtnSiparisSıl.Name = "BtnSiparisSıl";
            this.BtnSiparisSıl.Size = new System.Drawing.Size(132, 41);
            this.BtnSiparisSıl.TabIndex = 4;
            this.BtnSiparisSıl.Text = "Sil";
            // 
            // BtnSiparisleriListele
            // 
            this.BtnSiparisleriListele.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnSiparisleriListele.Appearance.Options.UseFont = true;
            this.BtnSiparisleriListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSiparisleriListele.ImageOptions.Image")));
            this.BtnSiparisleriListele.Location = new System.Drawing.Point(228, 229);
            this.BtnSiparisleriListele.Name = "BtnSiparisleriListele";
            this.BtnSiparisleriListele.Size = new System.Drawing.Size(132, 41);
            this.BtnSiparisleriListele.TabIndex = 3;
            this.BtnSiparisleriListele.Text = "Listele";
            this.BtnSiparisleriListele.Click += new System.EventHandler(this.BtnSiparisleriListele_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Sipariş ID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ürün ID:";
            // 
            // FrmSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 464);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmSiparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparisler";
            this.Load += new System.EventHandler(this.FrmSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnSiparisEkle;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.SimpleButton BtnSiparisGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSiparisSıl;
        private DevExpress.XtraEditors.SimpleButton BtnSiparisleriListele;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}