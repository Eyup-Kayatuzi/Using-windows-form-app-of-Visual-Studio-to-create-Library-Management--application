namespace KütüphaneOtomasyon
{
    partial class UyeSayfasi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Kişiler = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_kisiyenile = new System.Windows.Forms.Button();
            this.textBoxforkisiler = new System.Windows.Forms.TextBox();
            this.btn_kisiara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cikis1 = new System.Windows.Forms.Button();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimyil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_kitapYenile = new System.Windows.Forms.Button();
            this.textBoxforkitap = new System.Windows.Forms.TextBox();
            this.btn_kitapAra = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Kişiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Kişiler);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 606);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // Kişiler
            // 
            this.Kişiler.BackColor = System.Drawing.Color.LightSalmon;
            this.Kişiler.Controls.Add(this.button1);
            this.Kişiler.Controls.Add(this.btn_kisiyenile);
            this.Kişiler.Controls.Add(this.textBoxforkisiler);
            this.Kişiler.Controls.Add(this.btn_kisiara);
            this.Kişiler.Controls.Add(this.label2);
            this.Kişiler.Controls.Add(this.dataGridView1);
            this.Kişiler.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kişiler.Location = new System.Drawing.Point(4, 29);
            this.Kişiler.Name = "Kişiler";
            this.Kişiler.Padding = new System.Windows.Forms.Padding(3);
            this.Kişiler.Size = new System.Drawing.Size(926, 573);
            this.Kişiler.TabIndex = 0;
            this.Kişiler.Text = "Kişiler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Çıkış Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_kisiyenile
            // 
            this.btn_kisiyenile.Location = new System.Drawing.Point(523, 100);
            this.btn_kisiyenile.Name = "btn_kisiyenile";
            this.btn_kisiyenile.Size = new System.Drawing.Size(93, 35);
            this.btn_kisiyenile.TabIndex = 9;
            this.btn_kisiyenile.Text = "Yenile";
            this.btn_kisiyenile.UseVisualStyleBackColor = true;
            this.btn_kisiyenile.Click += new System.EventHandler(this.btn_kisiyenile_Click);
            // 
            // textBoxforkisiler
            // 
            this.textBoxforkisiler.Location = new System.Drawing.Point(417, 100);
            this.textBoxforkisiler.Multiline = true;
            this.textBoxforkisiler.Name = "textBoxforkisiler";
            this.textBoxforkisiler.Size = new System.Drawing.Size(100, 35);
            this.textBoxforkisiler.TabIndex = 8;
            this.textBoxforkisiler.TextChanged += new System.EventHandler(this.textBoxforkisiler_TextChanged);
            // 
            // btn_kisiara
            // 
            this.btn_kisiara.Location = new System.Drawing.Point(318, 100);
            this.btn_kisiara.Name = "btn_kisiara";
            this.btn_kisiara.Size = new System.Drawing.Size(93, 35);
            this.btn_kisiara.TabIndex = 7;
            this.btn_kisiara.Text = "Ara";
            this.btn_kisiara.UseVisualStyleBackColor = true;
            this.btn_kisiara.Click += new System.EventHandler(this.btn_kisiara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(396, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kişiler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 141);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(926, 290);
            this.dataGridView1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSalmon;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_cikis1);
            this.tabPage2.Controls.Add(this.dataGridView11);
            this.tabPage2.Controls.Add(this.btn_kitapYenile);
            this.tabPage2.Controls.Add(this.textBoxforkitap);
            this.tabPage2.Controls.Add(this.btn_kitapAra);
            this.tabPage2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(926, 573);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kitaplar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(365, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kitaplar";
            // 
            // btn_cikis1
            // 
            this.btn_cikis1.Location = new System.Drawing.Point(31, 480);
            this.btn_cikis1.Name = "btn_cikis1";
            this.btn_cikis1.Size = new System.Drawing.Size(135, 36);
            this.btn_cikis1.TabIndex = 4;
            this.btn_cikis1.Text = "Çıkış Yap";
            this.btn_cikis1.UseVisualStyleBackColor = true;
            this.btn_cikis1.Click += new System.EventHandler(this.btn_cikis1_Click);
            // 
            // dataGridView11
            // 
            this.dataGridView11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView11.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdil,
            this.yayinevi,
            this.tur,
            this.adet,
            this.sayfa,
            this.basimyil});
            this.dataGridView11.Location = new System.Drawing.Point(0, 151);
            this.dataGridView11.Name = "dataGridView11";
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView11.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView11.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView11.Size = new System.Drawing.Size(926, 290);
            this.dataGridView11.TabIndex = 3;
            this.dataGridView11.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView11_CellContentClick);
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KİTAP ID";
            this.kitapid.Name = "kitapid";
            // 
            // kitapisim
            // 
            this.kitapisim.HeaderText = "KİTAP İSİM";
            this.kitapisim.Name = "kitapisim";
            // 
            // kitapyazar
            // 
            this.kitapyazar.HeaderText = "KİTAP YAZAR";
            this.kitapyazar.Name = "kitapyazar";
            // 
            // kitapdil
            // 
            this.kitapdil.HeaderText = "KİTAP DİL";
            this.kitapdil.Name = "kitapdil";
            // 
            // yayinevi
            // 
            this.yayinevi.HeaderText = "YAYIN EVİ";
            this.yayinevi.Name = "yayinevi";
            // 
            // tur
            // 
            this.tur.HeaderText = "TÜR";
            this.tur.Name = "tur";
            // 
            // adet
            // 
            this.adet.HeaderText = "ADET";
            this.adet.Name = "adet";
            // 
            // sayfa
            // 
            this.sayfa.HeaderText = "SAYFA";
            this.sayfa.Name = "sayfa";
            // 
            // basimyil
            // 
            this.basimyil.HeaderText = "BASIM YILI";
            this.basimyil.Name = "basimyil";
            // 
            // btn_kitapYenile
            // 
            this.btn_kitapYenile.Location = new System.Drawing.Point(507, 110);
            this.btn_kitapYenile.Name = "btn_kitapYenile";
            this.btn_kitapYenile.Size = new System.Drawing.Size(93, 35);
            this.btn_kitapYenile.TabIndex = 2;
            this.btn_kitapYenile.Text = "Yenile";
            this.btn_kitapYenile.UseVisualStyleBackColor = true;
            this.btn_kitapYenile.Click += new System.EventHandler(this.btn_kitapYenile_Click_1);
            // 
            // textBoxforkitap
            // 
            this.textBoxforkitap.Location = new System.Drawing.Point(401, 110);
            this.textBoxforkitap.Multiline = true;
            this.textBoxforkitap.Name = "textBoxforkitap";
            this.textBoxforkitap.Size = new System.Drawing.Size(100, 35);
            this.textBoxforkitap.TabIndex = 1;
            this.textBoxforkitap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_kitapAra
            // 
            this.btn_kitapAra.Location = new System.Drawing.Point(302, 110);
            this.btn_kitapAra.Name = "btn_kitapAra";
            this.btn_kitapAra.Size = new System.Drawing.Size(93, 35);
            this.btn_kitapAra.TabIndex = 0;
            this.btn_kitapAra.Text = "Ara";
            this.btn_kitapAra.UseVisualStyleBackColor = true;
            this.btn_kitapAra.Click += new System.EventHandler(this.btn_kitapAra_Click_2);
            // 
            // UyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 606);
            this.Controls.Add(this.tabControl1);
            this.Name = "UyeSayfasi";
            this.Text = " ";
            this.Load += new System.EventHandler(this.UyeSayfasi_Load);
            this.tabControl1.ResumeLayout(false);
            this.Kişiler.ResumeLayout(false);
            this.Kişiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Kişiler;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_cikis1;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.Button btn_kitapYenile;
        private System.Windows.Forms.TextBox textBoxforkitap;
        private System.Windows.Forms.Button btn_kitapAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdil;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimyil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_kisiyenile;
        private System.Windows.Forms.TextBox textBoxforkisiler;
        private System.Windows.Forms.Button btn_kisiara;
        private System.Windows.Forms.Button button1;
    }
}