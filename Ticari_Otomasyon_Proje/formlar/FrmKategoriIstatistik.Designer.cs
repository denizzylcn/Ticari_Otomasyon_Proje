namespace Ticari_Otomasyon_Proje.formlar
{
    partial class FrmKategoriIstatistik
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblKategoriSayisi1 = new DevExpress.XtraEditors.LabelControl();
            this.lblKategoriSayisi = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblEnFazlaUrunuKategori = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblSonEklenenKategori = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.RosyBrown;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.lblKategoriSayisi1);
            this.panelControl1.Controls.Add(this.lblKategoriSayisi);
            this.panelControl1.Location = new System.Drawing.Point(744, 22);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(312, 156);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // lblKategoriSayisi1
            // 
            this.lblKategoriSayisi1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblKategoriSayisi1.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblKategoriSayisi1.Appearance.Options.UseFont = true;
            this.lblKategoriSayisi1.Appearance.Options.UseForeColor = true;
            this.lblKategoriSayisi1.Location = new System.Drawing.Point(12, 88);
            this.lblKategoriSayisi1.Margin = new System.Windows.Forms.Padding(10);
            this.lblKategoriSayisi1.Name = "lblKategoriSayisi1";
            this.lblKategoriSayisi1.Size = new System.Drawing.Size(174, 36);
            this.lblKategoriSayisi1.TabIndex = 4;
            this.lblKategoriSayisi1.Text = "labelControl3";
            this.lblKategoriSayisi1.Click += new System.EventHandler(this.lblKategoriSayisi1_Click);
            // 
            // lblKategoriSayisi
            // 
            this.lblKategoriSayisi.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblKategoriSayisi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblKategoriSayisi.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblKategoriSayisi.Appearance.Options.UseBackColor = true;
            this.lblKategoriSayisi.Appearance.Options.UseFont = true;
            this.lblKategoriSayisi.Appearance.Options.UseForeColor = true;
            this.lblKategoriSayisi.LineColor = System.Drawing.Color.White;
            this.lblKategoriSayisi.Location = new System.Drawing.Point(68, 36);
            this.lblKategoriSayisi.Margin = new System.Windows.Forms.Padding(10);
            this.lblKategoriSayisi.Name = "lblKategoriSayisi";
            this.lblKategoriSayisi.Size = new System.Drawing.Size(109, 21);
            this.lblKategoriSayisi.TabIndex = 3;
            this.lblKategoriSayisi.Text = "Kategori Sayısı";
            this.lblKategoriSayisi.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            this.lblKategoriSayisi.Click += new System.EventHandler(this.lblKategoriSayisi_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(220)))), ((int)(((byte)(88)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.lblEnFazlaUrunuKategori);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Location = new System.Drawing.Point(1399, 22);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(312, 156);
            this.panelControl2.TabIndex = 1;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // lblEnFazlaUrunuKategori
            // 
            this.lblEnFazlaUrunuKategori.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblEnFazlaUrunuKategori.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblEnFazlaUrunuKategori.Appearance.Options.UseFont = true;
            this.lblEnFazlaUrunuKategori.Appearance.Options.UseForeColor = true;
            this.lblEnFazlaUrunuKategori.Location = new System.Drawing.Point(15, 88);
            this.lblEnFazlaUrunuKategori.Margin = new System.Windows.Forms.Padding(12);
            this.lblEnFazlaUrunuKategori.Name = "lblEnFazlaUrunuKategori";
            this.lblEnFazlaUrunuKategori.Size = new System.Drawing.Size(174, 36);
            this.lblEnFazlaUrunuKategori.TabIndex = 6;
            this.lblEnFazlaUrunuKategori.Text = "labelControl3";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseBackColor = true;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.LineColor = System.Drawing.Color.White;
            this.labelControl4.Location = new System.Drawing.Point(10, 36);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(183, 21);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "En Fazla Ürünlü Kategori";
            this.labelControl4.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Brown;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.lblSonEklenenKategori);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Location = new System.Drawing.Point(1070, 22);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(312, 156);
            this.panelControl3.TabIndex = 2;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // lblSonEklenenKategori
            // 
            this.lblSonEklenenKategori.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.lblSonEklenenKategori.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblSonEklenenKategori.Appearance.Options.UseFont = true;
            this.lblSonEklenenKategori.Appearance.Options.UseForeColor = true;
            this.lblSonEklenenKategori.Location = new System.Drawing.Point(15, 85);
            this.lblSonEklenenKategori.Margin = new System.Windows.Forms.Padding(12);
            this.lblSonEklenenKategori.Name = "lblSonEklenenKategori";
            this.lblSonEklenenKategori.Size = new System.Drawing.Size(174, 36);
            this.lblSonEklenenKategori.TabIndex = 6;
            this.lblSonEklenenKategori.Text = "labelControl3";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.LineColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(25, 36);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(162, 21);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Son Eklenen Kategori ";
            this.labelControl2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Question;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(-1, 5);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(732, 611);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1250;
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(744, 187);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "ürün -stok";
            series1.SeriesID = 3;
            sideBySideBarSeriesView1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            series1.View = sideBySideBarSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(625, 306);
            this.chartControl1.TabIndex = 4;
            // 
            // FrmKategoriIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 637);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmKategoriIstatistik";
            this.Text = "Kategori İstatistik";
            this.Load += new System.EventHandler(this.FrmKategoriIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.LabelControl lblKategoriSayisi1;
        private DevExpress.XtraEditors.LabelControl lblKategoriSayisi;
        private DevExpress.XtraEditors.LabelControl lblEnFazlaUrunuKategori;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lblSonEklenenKategori;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}