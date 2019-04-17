namespace HastaneOtomasyon.WinUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tbKlinikler = new System.Windows.Forms.TabControl();
            this.tbHastane = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbIller = new System.Windows.Forms.ComboBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.dvgHastaneler = new System.Windows.Forms.DataGridView();
            this.txthastane = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDoktorlar = new System.Windows.Forms.TabPage();
            this.mskText = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbdKlinik = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dvgDoktor = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDrSoyad = new System.Windows.Forms.TextBox();
            this.txtDrUnvan = new System.Windows.Forms.TextBox();
            this.txtDrAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHastane = new System.Windows.Forms.ComboBox();
            this.cmbddILCE = new System.Windows.Forms.ComboBox();
            this.cmbdIller = new System.Windows.Forms.ComboBox();
            this.tbKLİNİKLER = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKlinikGuncelle = new System.Windows.Forms.Button();
            this.btnKlinikEkle = new System.Windows.Forms.Button();
            this.dgvKlinikler = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKlinik = new System.Windows.Forms.TextBox();
            this.tbKlinikler.SuspendLayout();
            this.tbHastane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHastaneler)).BeginInit();
            this.tbDoktorlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDoktor)).BeginInit();
            this.tbKLİNİKLER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlinikler)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKlinikler
            // 
            this.tbKlinikler.Controls.Add(this.tbHastane);
            this.tbKlinikler.Controls.Add(this.tbDoktorlar);
            this.tbKlinikler.Controls.Add(this.tbKLİNİKLER);
            this.tbKlinikler.Location = new System.Drawing.Point(1, 4);
            this.tbKlinikler.Margin = new System.Windows.Forms.Padding(6);
            this.tbKlinikler.Name = "tbKlinikler";
            this.tbKlinikler.SelectedIndex = 0;
            this.tbKlinikler.Size = new System.Drawing.Size(722, 385);
            this.tbKlinikler.TabIndex = 0;
            this.tbKlinikler.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tbKlinikler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbKlinikler_MouseClick);
            // 
            // tbHastane
            // 
            this.tbHastane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbHastane.BackgroundImage")));
            this.tbHastane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbHastane.Controls.Add(this.comboBox1);
            this.tbHastane.Controls.Add(this.label13);
            this.tbHastane.Controls.Add(this.cmbIller);
            this.tbHastane.Controls.Add(this.btnguncelle);
            this.tbHastane.Controls.Add(this.btnsil);
            this.tbHastane.Controls.Add(this.btnekle);
            this.tbHastane.Controls.Add(this.dvgHastaneler);
            this.tbHastane.Controls.Add(this.txthastane);
            this.tbHastane.Controls.Add(this.label3);
            this.tbHastane.Controls.Add(this.cmbIlce);
            this.tbHastane.Controls.Add(this.label2);
            this.tbHastane.Controls.Add(this.label1);
            this.tbHastane.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbHastane.Location = new System.Drawing.Point(4, 22);
            this.tbHastane.Name = "tbHastane";
            this.tbHastane.Padding = new System.Windows.Forms.Padding(3);
            this.tbHastane.Size = new System.Drawing.Size(714, 359);
            this.tbHastane.TabIndex = 0;
            this.tbHastane.Text = "HASTANELER";
            this.tbHastane.UseVisualStyleBackColor = true;
            this.tbHastane.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(24, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Klinik";
            // 
            // cmbIller
            // 
            this.cmbIller.FormattingEnabled = true;
            this.cmbIller.Location = new System.Drawing.Point(26, 34);
            this.cmbIller.Name = "cmbIller";
            this.cmbIller.Size = new System.Drawing.Size(152, 21);
            this.cmbIller.TabIndex = 10;
            this.cmbIller.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            this.cmbIller.SelectionChangeCommitted += new System.EventHandler(this.cmbIller_SelectionChangeCommitted);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Silver;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(399, 230);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(89, 34);
            this.btnguncelle.TabIndex = 9;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Silver;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(307, 230);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 34);
            this.btnsil.TabIndex = 8;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Silver;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(212, 230);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(76, 34);
            this.btnekle.TabIndex = 7;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvgHastaneler
            // 
            this.dvgHastaneler.BackgroundColor = System.Drawing.Color.White;
            this.dvgHastaneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgHastaneler.Location = new System.Drawing.Point(203, 34);
            this.dvgHastaneler.Name = "dvgHastaneler";
            this.dvgHastaneler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgHastaneler.Size = new System.Drawing.Size(505, 181);
            this.dvgHastaneler.TabIndex = 6;
            this.dvgHastaneler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgHastaneler_CellContentClick);
            this.dvgHastaneler.DoubleClick += new System.EventHandler(this.dvgHastaneler_DoubleClick);
            // 
            // txthastane
            // 
            this.txthastane.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthastane.Location = new System.Drawing.Point(26, 138);
            this.txthastane.Multiline = true;
            this.txthastane.Name = "txthastane";
            this.txthastane.Size = new System.Drawing.Size(152, 24);
            this.txthastane.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hastane Adı";
            // 
            // cmbIlce
            // 
            this.cmbIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(26, 84);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(152, 24);
            this.cmbIlce.TabIndex = 3;
            this.cmbIlce.SelectedIndexChanged += new System.EventHandler(this.cmbIlce_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlçe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir";
            // 
            // tbDoktorlar
            // 
            this.tbDoktorlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbDoktorlar.BackgroundImage")));
            this.tbDoktorlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbDoktorlar.Controls.Add(this.mskText);
            this.tbDoktorlar.Controls.Add(this.label10);
            this.tbDoktorlar.Controls.Add(this.cmbdKlinik);
            this.tbDoktorlar.Controls.Add(this.button4);
            this.tbDoktorlar.Controls.Add(this.button3);
            this.tbDoktorlar.Controls.Add(this.button2);
            this.tbDoktorlar.Controls.Add(this.dvgDoktor);
            this.tbDoktorlar.Controls.Add(this.label12);
            this.tbDoktorlar.Controls.Add(this.label11);
            this.tbDoktorlar.Controls.Add(this.label9);
            this.tbDoktorlar.Controls.Add(this.label8);
            this.tbDoktorlar.Controls.Add(this.txtDrSoyad);
            this.tbDoktorlar.Controls.Add(this.txtDrUnvan);
            this.tbDoktorlar.Controls.Add(this.txtDrAd);
            this.tbDoktorlar.Controls.Add(this.label7);
            this.tbDoktorlar.Controls.Add(this.label6);
            this.tbDoktorlar.Controls.Add(this.label5);
            this.tbDoktorlar.Controls.Add(this.cmbHastane);
            this.tbDoktorlar.Controls.Add(this.cmbddILCE);
            this.tbDoktorlar.Controls.Add(this.cmbdIller);
            this.tbDoktorlar.Location = new System.Drawing.Point(4, 22);
            this.tbDoktorlar.Name = "tbDoktorlar";
            this.tbDoktorlar.Padding = new System.Windows.Forms.Padding(3);
            this.tbDoktorlar.Size = new System.Drawing.Size(714, 359);
            this.tbDoktorlar.TabIndex = 1;
            this.tbDoktorlar.Text = "DOKTORLAR";
            this.tbDoktorlar.UseVisualStyleBackColor = true;
            this.tbDoktorlar.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // mskText
            // 
            this.mskText.Location = new System.Drawing.Point(282, 134);
            this.mskText.Mask = "(999) 000-0000";
            this.mskText.Name = "mskText";
            this.mskText.Size = new System.Drawing.Size(121, 20);
            this.mskText.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(441, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "KLİNİK";
            // 
            // cmbdKlinik
            // 
            this.cmbdKlinik.FormattingEnabled = true;
            this.cmbdKlinik.Location = new System.Drawing.Point(511, 86);
            this.cmbdKlinik.Name = "cmbdKlinik";
            this.cmbdKlinik.Size = new System.Drawing.Size(121, 21);
            this.cmbdKlinik.TabIndex = 20;
            this.cmbdKlinik.SelectedIndexChanged += new System.EventHandler(this.cmbdKlinik_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(610, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 19;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(525, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 35);
            this.button3.TabIndex = 18;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(444, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dvgDoktor
            // 
            this.dvgDoktor.BackgroundColor = System.Drawing.Color.White;
            this.dvgDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDoktor.Location = new System.Drawing.Point(20, 181);
            this.dvgDoktor.Name = "dvgDoktor";
            this.dvgDoktor.Size = new System.Drawing.Size(686, 167);
            this.dvgDoktor.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(225, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(231, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Soyad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(31, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ünvan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(36, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ad";
            // 
            // txtDrSoyad
            // 
            this.txtDrSoyad.Location = new System.Drawing.Point(282, 94);
            this.txtDrSoyad.Name = "txtDrSoyad";
            this.txtDrSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtDrSoyad.TabIndex = 9;
            // 
            // txtDrUnvan
            // 
            this.txtDrUnvan.Location = new System.Drawing.Point(76, 130);
            this.txtDrUnvan.Name = "txtDrUnvan";
            this.txtDrUnvan.Size = new System.Drawing.Size(121, 20);
            this.txtDrUnvan.TabIndex = 7;
            // 
            // txtDrAd
            // 
            this.txtDrAd.Location = new System.Drawing.Point(76, 94);
            this.txtDrAd.Name = "txtDrAd";
            this.txtDrAd.Size = new System.Drawing.Size(121, 20);
            this.txtDrAd.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(441, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "HASTANE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(232, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "İLÇE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(40, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "İL";
            // 
            // cmbHastane
            // 
            this.cmbHastane.FormattingEnabled = true;
            this.cmbHastane.Location = new System.Drawing.Point(511, 43);
            this.cmbHastane.Name = "cmbHastane";
            this.cmbHastane.Size = new System.Drawing.Size(121, 21);
            this.cmbHastane.TabIndex = 2;
            this.cmbHastane.SelectedIndexChanged += new System.EventHandler(this.cmbHastane_SelectedIndexChanged);
            this.cmbHastane.SelectionChangeCommitted += new System.EventHandler(this.cmbHastane_SelectionChangeCommitted);
            // 
            // cmbddILCE
            // 
            this.cmbddILCE.FormattingEnabled = true;
            this.cmbddILCE.Location = new System.Drawing.Point(282, 46);
            this.cmbddILCE.Name = "cmbddILCE";
            this.cmbddILCE.Size = new System.Drawing.Size(121, 21);
            this.cmbddILCE.TabIndex = 1;
            this.cmbddILCE.SelectedIndexChanged += new System.EventHandler(this.cmbdIlce_SelectedIndexChanged);
            this.cmbddILCE.SelectionChangeCommitted += new System.EventHandler(this.cmbdIlce_SelectionChangeCommitted);
            // 
            // cmbdIller
            // 
            this.cmbdIller.FormattingEnabled = true;
            this.cmbdIller.Location = new System.Drawing.Point(76, 46);
            this.cmbdIller.Name = "cmbdIller";
            this.cmbdIller.Size = new System.Drawing.Size(121, 21);
            this.cmbdIller.TabIndex = 0;
            this.cmbdIller.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbdIller.SelectionChangeCommitted += new System.EventHandler(this.cmbdIller_SelectionChangeCommitted);
            // 
            // tbKLİNİKLER
            // 
            this.tbKLİNİKLER.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbKLİNİKLER.BackgroundImage")));
            this.tbKLİNİKLER.Controls.Add(this.button1);
            this.tbKLİNİKLER.Controls.Add(this.btnKlinikGuncelle);
            this.tbKLİNİKLER.Controls.Add(this.btnKlinikEkle);
            this.tbKLİNİKLER.Controls.Add(this.dgvKlinikler);
            this.tbKLİNİKLER.Controls.Add(this.label4);
            this.tbKLİNİKLER.Controls.Add(this.txtKlinik);
            this.tbKLİNİKLER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKLİNİKLER.Location = new System.Drawing.Point(4, 22);
            this.tbKLİNİKLER.Name = "tbKLİNİKLER";
            this.tbKLİNİKLER.Padding = new System.Windows.Forms.Padding(3);
            this.tbKLİNİKLER.Size = new System.Drawing.Size(714, 359);
            this.tbKLİNİKLER.TabIndex = 2;
            this.tbKLİNİKLER.Text = "KLİNİKLER";
            this.tbKLİNİKLER.UseVisualStyleBackColor = true;
            this.tbKLİNİKLER.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(314, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnKlinikGuncelle
            // 
            this.btnKlinikGuncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btnKlinikGuncelle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKlinikGuncelle.Location = new System.Drawing.Point(395, 265);
            this.btnKlinikGuncelle.Name = "btnKlinikGuncelle";
            this.btnKlinikGuncelle.Size = new System.Drawing.Size(90, 33);
            this.btnKlinikGuncelle.TabIndex = 5;
            this.btnKlinikGuncelle.Text = "Güncelle";
            this.btnKlinikGuncelle.UseVisualStyleBackColor = false;
            this.btnKlinikGuncelle.Click += new System.EventHandler(this.btnKlinikGuncelle_Click);
            // 
            // btnKlinikEkle
            // 
            this.btnKlinikEkle.BackColor = System.Drawing.Color.Silver;
            this.btnKlinikEkle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKlinikEkle.Location = new System.Drawing.Point(233, 265);
            this.btnKlinikEkle.Name = "btnKlinikEkle";
            this.btnKlinikEkle.Size = new System.Drawing.Size(73, 33);
            this.btnKlinikEkle.TabIndex = 3;
            this.btnKlinikEkle.Text = "Ekle";
            this.btnKlinikEkle.UseVisualStyleBackColor = false;
            this.btnKlinikEkle.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvKlinikler
            // 
            this.dgvKlinikler.BackgroundColor = System.Drawing.Color.White;
            this.dgvKlinikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlinikler.Location = new System.Drawing.Point(203, 109);
            this.dgvKlinikler.Name = "dgvKlinikler";
            this.dgvKlinikler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlinikler.Size = new System.Drawing.Size(302, 130);
            this.dgvKlinikler.TabIndex = 2;
            this.dgvKlinikler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKlinikler_CellContentClick);
            this.dgvKlinikler.DoubleClick += new System.EventHandler(this.dgvKlinikler_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(200, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Klinik";
            // 
            // txtKlinik
            // 
            this.txtKlinik.Location = new System.Drawing.Point(250, 60);
            this.txtKlinik.Multiline = true;
            this.txtKlinik.Name = "txtKlinik";
            this.txtKlinik.Size = new System.Drawing.Size(255, 25);
            this.txtKlinik.TabIndex = 0;
            this.txtKlinik.TextChanged += new System.EventHandler(this.txtKlinik_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 379);
            this.Controls.Add(this.tbKlinikler);
            this.Name = "Form2";
            this.Text = "Randevu";
            this.Load += new System.EventHandler(this.Randevu_Load);
            this.tbKlinikler.ResumeLayout(false);
            this.tbHastane.ResumeLayout(false);
            this.tbHastane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHastaneler)).EndInit();
            this.tbDoktorlar.ResumeLayout(false);
            this.tbDoktorlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDoktor)).EndInit();
            this.tbKLİNİKLER.ResumeLayout(false);
            this.tbKLİNİKLER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlinikler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbDoktorlar;
        private System.Windows.Forms.TabPage tbHastane;
        private System.Windows.Forms.DataGridView dvgHastaneler;
        private System.Windows.Forms.TextBox txthastane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbKlinikler;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TabPage tbKLİNİKLER;
        private System.Windows.Forms.Button btnKlinikGuncelle;
        private System.Windows.Forms.Button btnKlinikEkle;
        private System.Windows.Forms.DataGridView dgvKlinikler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKlinik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDrSoyad;
        private System.Windows.Forms.TextBox txtDrUnvan;
        private System.Windows.Forms.TextBox txtDrAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHastane;
        private System.Windows.Forms.ComboBox cmbddILCE;
        private System.Windows.Forms.ComboBox cmbdIller;
        private System.Windows.Forms.DataGridView dvgDoktor;
        private System.Windows.Forms.ComboBox cmbIller;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbdKlinik;
        private System.Windows.Forms.MaskedTextBox mskText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}