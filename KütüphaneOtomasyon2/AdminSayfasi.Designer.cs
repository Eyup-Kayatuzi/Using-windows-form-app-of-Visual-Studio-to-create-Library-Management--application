namespace KütüphaneOtomasyon
{
    partial class AdminSayfasi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSayfasi));
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimyili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_kitaptemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_kitapsil = new System.Windows.Forms.Button();
            this.btn_kitapguncelle = new System.Windows.Forms.Button();
            this.btn_kitapekle = new System.Windows.Forms.Button();
            this.txt_dil = new System.Windows.Forms.TextBox();
            this.txt_kitapbasimyil = new System.Windows.Forms.TextBox();
            this.txt_kitapsayfa = new System.Windows.Forms.TextBox();
            this.txt_kitapadet = new System.Windows.Forms.TextBox();
            this.txt_kitaptür = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_kitapyayinevi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kitapisim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_kitapyazar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_kitapid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_kullaniciAd = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.txt_kullaniciAd = new System.Windows.Forms.TextBox();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_yetki = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_yetki = new System.Windows.Forms.TextBox();
            this.lbl_olusturmaTarih = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.groupBox_Uyeler = new System.Windows.Forms.GroupBox();
            this.btn_kisiAra = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_kisiYenile = new System.Windows.Forms.Button();
            this.btn_kitapAra = new System.Windows.Forms.Button();
            this.btn_kitapYenile = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.textBoxenson = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_Uyeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslik.Location = new System.Drawing.Point(317, 6);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(112, 33);
            this.lbl_baslik.TabIndex = 1;
            this.lbl_baslik.Text = "ÜYELER";
            this.lbl_baslik.Click += new System.EventHandler(this.lbl_baslik_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(557, 197);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapid,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdili,
            this.yayinevi,
            this.tur,
            this.adet,
            this.sayfa,
            this.basimyili});
            this.dataGridView2.Location = new System.Drawing.Point(575, 42);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(557, 197);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // kitapid
            // 
            this.kitapid.HeaderText = "KİTAP İD";
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
            // kitapdili
            // 
            this.kitapdili.HeaderText = "KİTAP DİLİ";
            this.kitapdili.Name = "kitapdili";
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
            // basimyili
            // 
            this.basimyili.HeaderText = "BASIM YILI";
            this.basimyili.Name = "basimyili";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(904, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİTAPLAR";
            this.label1.Click += new System.EventHandler(this.lbl_baslik_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kitaptemizle);
            this.groupBox1.Controls.Add(this.btn_kitapsil);
            this.groupBox1.Controls.Add(this.btn_kitapguncelle);
            this.groupBox1.Controls.Add(this.btn_kitapekle);
            this.groupBox1.Controls.Add(this.txt_dil);
            this.groupBox1.Controls.Add(this.txt_kitapbasimyil);
            this.groupBox1.Controls.Add(this.txt_kitapsayfa);
            this.groupBox1.Controls.Add(this.txt_kitapadet);
            this.groupBox1.Controls.Add(this.txt_kitaptür);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_kitapyayinevi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_kitapisim);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_kitapyazar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_kitapid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(575, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UyeIslemler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox_Uyeler_Enter);
            // 
            // btn_kitaptemizle
            // 
            this.btn_kitaptemizle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitaptemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kitaptemizle.ImageKey = "clear.ico";
            this.btn_kitaptemizle.ImageList = this.ımageList1;
            this.btn_kitaptemizle.Location = new System.Drawing.Point(298, 246);
            this.btn_kitaptemizle.Name = "btn_kitaptemizle";
            this.btn_kitaptemizle.Size = new System.Drawing.Size(259, 32);
            this.btn_kitaptemizle.TabIndex = 2;
            this.btn_kitaptemizle.Text = "Temizle";
            this.btn_kitaptemizle.UseVisualStyleBackColor = true;
            this.btn_kitaptemizle.Click += new System.EventHandler(this.btn_kitaptemizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.ico");
            this.ımageList1.Images.SetKeyName(1, "clear.ico");
            this.ımageList1.Images.SetKeyName(2, "del.ico");
            this.ımageList1.Images.SetKeyName(3, "update.ico");
            this.ımageList1.Images.SetKeyName(4, "Dakirby309-Windows-8-Metro-Folders-OS-Exit-Full-Screen-Metro.ico");
            // 
            // btn_kitapsil
            // 
            this.btn_kitapsil.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapsil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kitapsil.ImageKey = "del.ico";
            this.btn_kitapsil.ImageList = this.ımageList1;
            this.btn_kitapsil.Location = new System.Drawing.Point(298, 208);
            this.btn_kitapsil.Name = "btn_kitapsil";
            this.btn_kitapsil.Size = new System.Drawing.Size(259, 32);
            this.btn_kitapsil.TabIndex = 2;
            this.btn_kitapsil.Text = "Sil";
            this.btn_kitapsil.UseVisualStyleBackColor = true;
            this.btn_kitapsil.Click += new System.EventHandler(this.btn_kitapsil_Click);
            // 
            // btn_kitapguncelle
            // 
            this.btn_kitapguncelle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kitapguncelle.ImageKey = "update.ico";
            this.btn_kitapguncelle.ImageList = this.ımageList1;
            this.btn_kitapguncelle.Location = new System.Drawing.Point(12, 246);
            this.btn_kitapguncelle.Name = "btn_kitapguncelle";
            this.btn_kitapguncelle.Size = new System.Drawing.Size(244, 32);
            this.btn_kitapguncelle.TabIndex = 2;
            this.btn_kitapguncelle.Text = "Guncelle";
            this.btn_kitapguncelle.UseVisualStyleBackColor = true;
            this.btn_kitapguncelle.Click += new System.EventHandler(this.btn_kitapguncelle_Click);
            // 
            // btn_kitapekle
            // 
            this.btn_kitapekle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kitapekle.ImageKey = "add.ico";
            this.btn_kitapekle.ImageList = this.ımageList1;
            this.btn_kitapekle.Location = new System.Drawing.Point(12, 208);
            this.btn_kitapekle.Name = "btn_kitapekle";
            this.btn_kitapekle.Size = new System.Drawing.Size(244, 32);
            this.btn_kitapekle.TabIndex = 2;
            this.btn_kitapekle.Text = "Ekle";
            this.btn_kitapekle.UseVisualStyleBackColor = true;
            this.btn_kitapekle.Click += new System.EventHandler(this.btn_kitapekle_Click);
            // 
            // txt_dil
            // 
            this.txt_dil.Location = new System.Drawing.Point(46, 162);
            this.txt_dil.Name = "txt_dil";
            this.txt_dil.Size = new System.Drawing.Size(210, 20);
            this.txt_dil.TabIndex = 1;
            // 
            // txt_kitapbasimyil
            // 
            this.txt_kitapbasimyil.Location = new System.Drawing.Point(353, 162);
            this.txt_kitapbasimyil.Name = "txt_kitapbasimyil";
            this.txt_kitapbasimyil.Size = new System.Drawing.Size(198, 20);
            this.txt_kitapbasimyil.TabIndex = 1;
            // 
            // txt_kitapsayfa
            // 
            this.txt_kitapsayfa.Location = new System.Drawing.Point(353, 133);
            this.txt_kitapsayfa.Name = "txt_kitapsayfa";
            this.txt_kitapsayfa.Size = new System.Drawing.Size(198, 20);
            this.txt_kitapsayfa.TabIndex = 1;
            // 
            // txt_kitapadet
            // 
            this.txt_kitapadet.Location = new System.Drawing.Point(353, 98);
            this.txt_kitapadet.Name = "txt_kitapadet";
            this.txt_kitapadet.Size = new System.Drawing.Size(198, 20);
            this.txt_kitapadet.TabIndex = 1;
            // 
            // txt_kitaptür
            // 
            this.txt_kitaptür.Location = new System.Drawing.Point(353, 66);
            this.txt_kitaptür.Name = "txt_kitaptür";
            this.txt_kitaptür.Size = new System.Drawing.Size(198, 20);
            this.txt_kitaptür.TabIndex = 1;
            this.txt_kitaptür.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(262, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Basım Yıl:";
            this.label10.Click += new System.EventHandler(this.lbl_isim_Click);
            // 
            // txt_kitapyayinevi
            // 
            this.txt_kitapyayinevi.Location = new System.Drawing.Point(353, 31);
            this.txt_kitapyayinevi.Name = "txt_kitapyayinevi";
            this.txt_kitapyayinevi.Size = new System.Drawing.Size(198, 20);
            this.txt_kitapyayinevi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(262, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sayfa:";
            this.label3.Click += new System.EventHandler(this.lbl_isim_Click);
            // 
            // txt_kitapisim
            // 
            this.txt_kitapisim.Location = new System.Drawing.Point(116, 73);
            this.txt_kitapisim.Name = "txt_kitapisim";
            this.txt_kitapisim.Size = new System.Drawing.Size(140, 20);
            this.txt_kitapisim.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(262, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Adet:";
            this.label9.Click += new System.EventHandler(this.lbl_isim_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dil:";
            // 
            // txt_
            // 
            this.txt_.AutoSize = true;
            this.txt_.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_.Location = new System.Drawing.Point(262, 61);
            this.txt_.Name = "txt_";
            this.txt_.Size = new System.Drawing.Size(44, 25);
            this.txt_.TabIndex = 0;
            this.txt_.Text = "Tür:";
            this.txt_.Click += new System.EventHandler(this.lbl_isim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(262, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yayın Evi:";
            this.label5.Click += new System.EventHandler(this.lbl_isim_Click);
            // 
            // txt_kitapyazar
            // 
            this.txt_kitapyazar.Location = new System.Drawing.Point(116, 116);
            this.txt_kitapyazar.Name = "txt_kitapyazar";
            this.txt_kitapyazar.Size = new System.Drawing.Size(140, 20);
            this.txt_kitapyazar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(7, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kitap İsim:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kitap Yazar:";
            this.label7.Click += new System.EventHandler(this.lbl_kullaniciAd_Click);
            // 
            // txt_kitapid
            // 
            this.txt_kitapid.Location = new System.Drawing.Point(46, 31);
            this.txt_kitapid.Name = "txt_kitapid";
            this.txt_kitapid.Size = new System.Drawing.Size(210, 20);
            this.txt_kitapid.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(7, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_id.Location = new System.Drawing.Point(7, 27);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(33, 25);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(61, 31);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(195, 20);
            this.txt_id.TabIndex = 1;
            // 
            // lbl_kullaniciAd
            // 
            this.lbl_kullaniciAd.AutoSize = true;
            this.lbl_kullaniciAd.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciAd.Location = new System.Drawing.Point(7, 111);
            this.lbl_kullaniciAd.Name = "lbl_kullaniciAd";
            this.lbl_kullaniciAd.Size = new System.Drawing.Size(113, 25);
            this.lbl_kullaniciAd.TabIndex = 0;
            this.lbl_kullaniciAd.Text = "Kullanıcı Adı:";
            this.lbl_kullaniciAd.Click += new System.EventHandler(this.lbl_kullaniciAd_Click);
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyisim.Location = new System.Drawing.Point(7, 67);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(78, 25);
            this.lbl_soyisim.TabIndex = 0;
            this.lbl_soyisim.Text = "Soyisim:";
            // 
            // txt_kullaniciAd
            // 
            this.txt_kullaniciAd.Location = new System.Drawing.Point(116, 116);
            this.txt_kullaniciAd.Name = "txt_kullaniciAd";
            this.txt_kullaniciAd.Size = new System.Drawing.Size(140, 20);
            this.txt_kullaniciAd.TabIndex = 1;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.Location = new System.Drawing.Point(293, 27);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(48, 25);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "Isim:";
            this.lbl_isim.Click += new System.EventHandler(this.lbl_isim_Click);
            // 
            // lbl_yetki
            // 
            this.lbl_yetki.AutoSize = true;
            this.lbl_yetki.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yetki.Location = new System.Drawing.Point(7, 157);
            this.lbl_yetki.Name = "lbl_yetki";
            this.lbl_yetki.Size = new System.Drawing.Size(57, 25);
            this.lbl_yetki.TabIndex = 0;
            this.lbl_yetki.Text = "Yetki:";
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(82, 73);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(174, 20);
            this.txt_soyisim.TabIndex = 1;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(293, 112);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(53, 25);
            this.lbl_sifre.TabIndex = 0;
            this.lbl_sifre.Text = "Sifre:";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(347, 31);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(210, 20);
            this.txt_isim.TabIndex = 1;
            // 
            // txt_yetki
            // 
            this.txt_yetki.Location = new System.Drawing.Point(61, 162);
            this.txt_yetki.Name = "txt_yetki";
            this.txt_yetki.Size = new System.Drawing.Size(195, 20);
            this.txt_yetki.TabIndex = 1;
            // 
            // lbl_olusturmaTarih
            // 
            this.lbl_olusturmaTarih.AutoSize = true;
            this.lbl_olusturmaTarih.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_olusturmaTarih.Location = new System.Drawing.Point(293, 70);
            this.lbl_olusturmaTarih.Name = "lbl_olusturmaTarih";
            this.lbl_olusturmaTarih.Size = new System.Drawing.Size(144, 25);
            this.lbl_olusturmaTarih.TabIndex = 0;
            this.lbl_olusturmaTarih.Text = "Olusturma Tarih:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(345, 116);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(212, 20);
            this.txt_sifre.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ekle.ImageKey = "add.ico";
            this.btn_ekle.ImageList = this.ımageList1;
            this.btn_ekle.Location = new System.Drawing.Point(12, 208);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(244, 32);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guncelle.ImageKey = "update.ico";
            this.btn_guncelle.ImageList = this.ımageList1;
            this.btn_guncelle.Location = new System.Drawing.Point(12, 246);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(244, 32);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Guncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sil.ImageKey = "del.ico";
            this.btn_Sil.ImageList = this.ımageList1;
            this.btn_Sil.Location = new System.Drawing.Point(298, 208);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(259, 32);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.ImageKey = "clear.ico";
            this.btn_temizle.ImageList = this.ımageList1;
            this.btn_temizle.Location = new System.Drawing.Point(298, 246);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(259, 32);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // groupBox_Uyeler
            // 
            this.groupBox_Uyeler.Controls.Add(this.textBoxenson);
            this.groupBox_Uyeler.Controls.Add(this.btn_temizle);
            this.groupBox_Uyeler.Controls.Add(this.btn_Sil);
            this.groupBox_Uyeler.Controls.Add(this.btn_guncelle);
            this.groupBox_Uyeler.Controls.Add(this.btn_ekle);
            this.groupBox_Uyeler.Controls.Add(this.txt_sifre);
            this.groupBox_Uyeler.Controls.Add(this.lbl_olusturmaTarih);
            this.groupBox_Uyeler.Controls.Add(this.txt_yetki);
            this.groupBox_Uyeler.Controls.Add(this.txt_isim);
            this.groupBox_Uyeler.Controls.Add(this.lbl_sifre);
            this.groupBox_Uyeler.Controls.Add(this.txt_soyisim);
            this.groupBox_Uyeler.Controls.Add(this.lbl_yetki);
            this.groupBox_Uyeler.Controls.Add(this.lbl_isim);
            this.groupBox_Uyeler.Controls.Add(this.txt_kullaniciAd);
            this.groupBox_Uyeler.Controls.Add(this.lbl_soyisim);
            this.groupBox_Uyeler.Controls.Add(this.lbl_kullaniciAd);
            this.groupBox_Uyeler.Controls.Add(this.txt_id);
            this.groupBox_Uyeler.Controls.Add(this.lbl_id);
            this.groupBox_Uyeler.Location = new System.Drawing.Point(12, 245);
            this.groupBox_Uyeler.Name = "groupBox_Uyeler";
            this.groupBox_Uyeler.Size = new System.Drawing.Size(557, 315);
            this.groupBox_Uyeler.TabIndex = 0;
            this.groupBox_Uyeler.TabStop = false;
            this.groupBox_Uyeler.Text = "UyeIslemler";
            this.groupBox_Uyeler.Enter += new System.EventHandler(this.groupBox_Uyeler_Enter);
            // 
            // btn_kisiAra
            // 
            this.btn_kisiAra.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kisiAra.Location = new System.Drawing.Point(12, 13);
            this.btn_kisiAra.Name = "btn_kisiAra";
            this.btn_kisiAra.Size = new System.Drawing.Size(75, 20);
            this.btn_kisiAra.TabIndex = 4;
            this.btn_kisiAra.Text = "Ara";
            this.btn_kisiAra.UseVisualStyleBackColor = true;
            this.btn_kisiAra.Click += new System.EventHandler(this.btn_kisiAra_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // btn_kisiYenile
            // 
            this.btn_kisiYenile.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kisiYenile.Location = new System.Drawing.Point(200, 13);
            this.btn_kisiYenile.Name = "btn_kisiYenile";
            this.btn_kisiYenile.Size = new System.Drawing.Size(75, 20);
            this.btn_kisiYenile.TabIndex = 4;
            this.btn_kisiYenile.Text = "Yenile";
            this.btn_kisiYenile.UseVisualStyleBackColor = true;
            this.btn_kisiYenile.Click += new System.EventHandler(this.btn_kisiYenile_Click);
            // 
            // btn_kitapAra
            // 
            this.btn_kitapAra.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapAra.Location = new System.Drawing.Point(575, 15);
            this.btn_kitapAra.Name = "btn_kitapAra";
            this.btn_kitapAra.Size = new System.Drawing.Size(75, 20);
            this.btn_kitapAra.TabIndex = 4;
            this.btn_kitapAra.Text = "Ara";
            this.btn_kitapAra.UseVisualStyleBackColor = true;
            this.btn_kitapAra.Click += new System.EventHandler(this.btn_kitapAra_Click);
            // 
            // btn_kitapYenile
            // 
            this.btn_kitapYenile.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapYenile.Location = new System.Drawing.Point(762, 16);
            this.btn_kitapYenile.Name = "btn_kitapYenile";
            this.btn_kitapYenile.Size = new System.Drawing.Size(75, 20);
            this.btn_kitapYenile.TabIndex = 4;
            this.btn_kitapYenile.Text = "Yenile";
            this.btn_kitapYenile.UseVisualStyleBackColor = true;
            this.btn_kitapYenile.Click += new System.EventHandler(this.btn_kitapYenile_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(656, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_cikis.ImageIndex = 4;
            this.btn_cikis.ImageList = this.ımageList1;
            this.btn_cikis.Location = new System.Drawing.Point(504, 577);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(137, 34);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // textBoxenson
            // 
            this.textBoxenson.Location = new System.Drawing.Point(443, 72);
            this.textBoxenson.Name = "textBoxenson";
            this.textBoxenson.Size = new System.Drawing.Size(100, 20);
            this.textBoxenson.TabIndex = 3;
            // 
            // AdminSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1142, 642);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_kitapYenile);
            this.Controls.Add(this.btn_kitapAra);
            this.Controls.Add(this.btn_kisiYenile);
            this.Controls.Add(this.btn_kisiAra);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_baslik);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Uyeler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminSayfasi";
            this.Text = "AdminSayfasi";
            this.Load += new System.EventHandler(this.AdminSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Uyeler.ResumeLayout(false);
            this.groupBox_Uyeler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimyili;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_kitaptemizle;
        private System.Windows.Forms.Button btn_kitapsil;
        private System.Windows.Forms.Button btn_kitapguncelle;
        private System.Windows.Forms.Button btn_kitapekle;
        private System.Windows.Forms.TextBox txt_dil;
        private System.Windows.Forms.TextBox txt_kitapyayinevi;
        private System.Windows.Forms.TextBox txt_kitapisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kitapyazar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_kitapid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_kitapbasimyil;
        private System.Windows.Forms.TextBox txt_kitapsayfa;
        private System.Windows.Forms.TextBox txt_kitapadet;
        private System.Windows.Forms.TextBox txt_kitaptür;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_kullaniciAd;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.TextBox txt_kullaniciAd;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_yetki;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_yetki;
        private System.Windows.Forms.Label lbl_olusturmaTarih;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.GroupBox groupBox_Uyeler;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_kisiAra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_kisiYenile;
        private System.Windows.Forms.Button btn_kitapAra;
        private System.Windows.Forms.Button btn_kitapYenile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.TextBox textBoxenson;
    }
}