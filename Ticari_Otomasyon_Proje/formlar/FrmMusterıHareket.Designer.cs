namespace Ticari_Otomasyon_Proje.formlar
{
    partial class FrmMusterıHareket
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblBugunkuSatis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lblEnFazlaSatılanUrun = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.gridControl1.Location = new System.Drawing.Point(17, 257);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(8);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1287, 390);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 1562;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.lblToplamSatis);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Location = new System.Drawing.Point(22, 22);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(295, 202);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblToplamSatis.Location = new System.Drawing.Point(73, 129);
            this.lblToplamSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(137, 27);
            this.lblToplamSatis.TabIndex = 1;
            this.lblToplamSatis.Text = "Toplam Satış";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(73, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Satış";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.lblBugunkuSatis);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Location = new System.Drawing.Point(358, 19);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(10);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(295, 202);
            this.panelControl2.TabIndex = 2;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // lblBugunkuSatis
            // 
            this.lblBugunkuSatis.AutoSize = true;
            this.lblBugunkuSatis.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblBugunkuSatis.Location = new System.Drawing.Point(96, 130);
            this.lblBugunkuSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBugunkuSatis.Name = "lblBugunkuSatis";
            this.lblBugunkuSatis.Size = new System.Drawing.Size(137, 27);
            this.lblBugunkuSatis.TabIndex = 2;
            this.lblBugunkuSatis.Text = "Toplam Satış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label3.Location = new System.Drawing.Point(84, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bugünkü Satış";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.lblEnFazlaSatılanUrun);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Location = new System.Drawing.Point(692, 22);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(10);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(295, 202);
            this.panelControl3.TabIndex = 3;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // lblEnFazlaSatılanUrun
            // 
            this.lblEnFazlaSatılanUrun.AutoSize = true;
            this.lblEnFazlaSatılanUrun.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblEnFazlaSatılanUrun.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblEnFazlaSatılanUrun.Location = new System.Drawing.Point(96, 127);
            this.lblEnFazlaSatılanUrun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnFazlaSatılanUrun.Name = "lblEnFazlaSatılanUrun";
            this.lblEnFazlaSatılanUrun.Size = new System.Drawing.Size(137, 27);
            this.lblEnFazlaSatılanUrun.TabIndex = 2;
            this.lblEnFazlaSatılanUrun.Text = "Toplam Satış";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label4.Location = new System.Drawing.Point(47, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "En Fazla Satılan Ürün";
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.Controls.Add(this.lblMusteri);
            this.panelControl4.Controls.Add(this.label5);
            this.panelControl4.Location = new System.Drawing.Point(1009, 22);
            this.panelControl4.Margin = new System.Windows.Forms.Padding(12);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(295, 202);
            this.panelControl4.TabIndex = 4;
            this.panelControl4.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl4_Paint);
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblMusteri.Font = new System.Drawing.Font("Tahoma", 13F);
            this.lblMusteri.Location = new System.Drawing.Point(90, 127);
            this.lblMusteri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(137, 27);
            this.lblMusteri.TabIndex = 2;
            this.lblMusteri.Text = "Toplam Satış";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(30, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "En Fazla Alım Yapan Müşteri";
            // 
            // FrmMusterıHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 679);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmMusterıHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Hareket";
            this.Load += new System.EventHandler(this.FrmMusterıHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBugunkuSatis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnFazlaSatılanUrun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label label5;
    }
}