namespace Ticari_Otomasyon_Proje
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKullanıcıAd = new System.Windows.Forms.TextBox();
            this.TxtSıfre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGırısYap = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(166, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Ad:";
            // 
            // TxtKullanıcıAd
            // 
            this.TxtKullanıcıAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullanıcıAd.Location = new System.Drawing.Point(310, 167);
            this.TxtKullanıcıAd.Name = "TxtKullanıcıAd";
            this.TxtKullanıcıAd.Size = new System.Drawing.Size(186, 30);
            this.TxtKullanıcıAd.TabIndex = 1;
            // 
            // TxtSıfre
            // 
            this.TxtSıfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSıfre.Location = new System.Drawing.Point(310, 231);
            this.TxtSıfre.Name = "TxtSıfre";
            this.TxtSıfre.PasswordChar = '*';
            this.TxtSıfre.Size = new System.Drawing.Size(186, 30);
            this.TxtSıfre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(166, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // btnGırısYap
            // 
            this.btnGırısYap.Location = new System.Drawing.Point(190, 314);
            this.btnGırısYap.Name = "btnGırısYap";
            this.btnGırısYap.Size = new System.Drawing.Size(124, 47);
            this.btnGırısYap.TabIndex = 4;
            this.btnGırısYap.Text = "Giriş Yap";
            this.btnGırısYap.Click += new System.EventHandler(this.btnGırısYap_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(389, 314);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(124, 47);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Çıkış Yap";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(165, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "TİCARİ OTOMASYON";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(703, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnGırısYap);
            this.Controls.Add(this.TxtSıfre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKullanıcıAd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKullanıcıAd;
        private System.Windows.Forms.TextBox TxtSıfre;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnGırısYap;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label3;
    }
}