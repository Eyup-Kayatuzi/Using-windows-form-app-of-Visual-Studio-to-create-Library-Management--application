namespace KütüphaneOtomasyon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_kullaniciad = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_kullaniciAd = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.grpbx_giris = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbx_giris.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_kullaniciad
            // 
            this.lbl_kullaniciad.AutoSize = true;
            this.lbl_kullaniciad.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciad.Location = new System.Drawing.Point(200, 56);
            this.lbl_kullaniciad.Name = "lbl_kullaniciad";
            this.lbl_kullaniciad.Size = new System.Drawing.Size(118, 25);
            this.lbl_kullaniciad.TabIndex = 1;
            this.lbl_kullaniciad.Text = "Kullanıcı Adı :";
            this.lbl_kullaniciad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(200, 98);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(58, 25);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre :";
            this.lbl_sifre.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_kullaniciAd
            // 
            this.txt_kullaniciAd.Location = new System.Drawing.Point(6, 29);
            this.txt_kullaniciAd.Name = "txt_kullaniciAd";
            this.txt_kullaniciAd.Size = new System.Drawing.Size(225, 32);
            this.txt_kullaniciAd.TabIndex = 0;
            this.txt_kullaniciAd.TextChanged += new System.EventHandler(this.txt_kullaniciAd_TextChanged);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(6, 71);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(225, 32);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.UseSystemPasswordChar = true;
            this.txt_sifre.TextChanged += new System.EventHandler(this.txt_sifre_TextChanged);
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisYap.ImageKey = "(none)";
            this.btn_girisYap.Location = new System.Drawing.Point(324, 140);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(95, 36);
            this.btn_girisYap.TabIndex = 3;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.UseVisualStyleBackColor = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(454, 140);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(95, 36);
            this.btn_temizle.TabIndex = 4;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // grpbx_giris
            // 
            this.grpbx_giris.Controls.Add(this.txt_sifre);
            this.grpbx_giris.Controls.Add(this.txt_kullaniciAd);
            this.grpbx_giris.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbx_giris.Location = new System.Drawing.Point(314, 20);
            this.grpbx_giris.Name = "grpbx_giris";
            this.grpbx_giris.Size = new System.Drawing.Size(246, 114);
            this.grpbx_giris.TabIndex = 2;
            this.grpbx_giris.TabStop = false;
            this.grpbx_giris.Text = "Giris";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 202);
            this.Controls.Add(this.grpbx_giris);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kullaniciad);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbx_giris.ResumeLayout(false);
            this.grpbx_giris.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_kullaniciad;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciAd;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_girisYap;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.GroupBox grpbx_giris;
    }
}

