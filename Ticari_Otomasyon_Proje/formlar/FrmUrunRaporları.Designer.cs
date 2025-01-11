namespace Ticari_Otomasyon_Proje.formlar
{
    partial class FrmUrunRaporları
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunRaporları));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnPdfRaporu = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcelRaporu = new DevExpress.XtraEditors.SimpleButton();
            this.btniptal = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 157);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(740, 510);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnPdfRaporu
            // 
            this.btnPdfRaporu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfRaporu.ImageOptions.Image")));
            this.btnPdfRaporu.Location = new System.Drawing.Point(12, 54);
            this.btnPdfRaporu.Name = "btnPdfRaporu";
            this.btnPdfRaporu.Size = new System.Drawing.Size(189, 61);
            this.btnPdfRaporu.TabIndex = 1;
            this.btnPdfRaporu.Text = "Pdf Raporu";
            this.btnPdfRaporu.Click += new System.EventHandler(this.btnPdfRaporu_Click);
            // 
            // btnExcelRaporu
            // 
            this.btnExcelRaporu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelRaporu.ImageOptions.Image")));
            this.btnExcelRaporu.Location = new System.Drawing.Point(259, 54);
            this.btnExcelRaporu.Name = "btnExcelRaporu";
            this.btnExcelRaporu.Size = new System.Drawing.Size(189, 61);
            this.btnExcelRaporu.TabIndex = 2;
            this.btnExcelRaporu.Text = "Excel Raporu";
            // 
            // btniptal
            // 
            this.btniptal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btniptal.ImageOptions.Image")));
            this.btniptal.Location = new System.Drawing.Point(523, 54);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(189, 61);
            this.btniptal.TabIndex = 3;
            this.btniptal.Text = "İptal";
            // 
            // FrmUrunRaporları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 679);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnExcelRaporu);
            this.Controls.Add(this.btnPdfRaporu);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunRaporları";
            this.Text = "FrmUrunRaporları";
            this.Load += new System.EventHandler(this.FrmUrunRaporları_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnPdfRaporu;
        private DevExpress.XtraEditors.SimpleButton btnExcelRaporu;
        private DevExpress.XtraEditors.SimpleButton btniptal;
    }
}