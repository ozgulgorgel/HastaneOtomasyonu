namespace HastaneOtomasyon.WinUI
{
    partial class KullanıcıPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıPanel));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbKdoktor = new System.Windows.Forms.ComboBox();
            this.cmbKklinik = new System.Windows.Forms.ComboBox();
            this.cmbKhast = new System.Windows.Forms.ComboBox();
            this.cmbKilce = new System.Windows.Forms.ComboBox();
            this.cmbKSehir = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.cmbKdoktor);
            this.tabPage1.Controls.Add(this.cmbKklinik);
            this.tabPage1.Controls.Add(this.cmbKhast);
            this.tabPage1.Controls.Add(this.cmbKilce);
            this.tabPage1.Controls.Add(this.cmbKSehir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(576, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RANDEVU AL";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "RANDEVU AL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(296, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(296, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doktor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(296, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Klinik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(21, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hastane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "İlce";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şehir";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cmbKdoktor
            // 
            this.cmbKdoktor.FormattingEnabled = true;
            this.cmbKdoktor.Location = new System.Drawing.Point(342, 87);
            this.cmbKdoktor.Name = "cmbKdoktor";
            this.cmbKdoktor.Size = new System.Drawing.Size(191, 21);
            this.cmbKdoktor.TabIndex = 4;
            // 
            // cmbKklinik
            // 
            this.cmbKklinik.FormattingEnabled = true;
            this.cmbKklinik.Location = new System.Drawing.Point(342, 42);
            this.cmbKklinik.Name = "cmbKklinik";
            this.cmbKklinik.Size = new System.Drawing.Size(191, 21);
            this.cmbKklinik.TabIndex = 3;
            this.cmbKklinik.SelectedIndexChanged += new System.EventHandler(this.cmbKklinik_SelectedIndexChanged);
            this.cmbKklinik.SelectionChangeCommitted += new System.EventHandler(this.cmbKklinik_SelectionChangeCommitted);
            // 
            // cmbKhast
            // 
            this.cmbKhast.FormattingEnabled = true;
            this.cmbKhast.Location = new System.Drawing.Point(74, 128);
            this.cmbKhast.Name = "cmbKhast";
            this.cmbKhast.Size = new System.Drawing.Size(171, 21);
            this.cmbKhast.TabIndex = 2;
            this.cmbKhast.SelectedIndexChanged += new System.EventHandler(this.cmbKhast_SelectedIndexChanged);
            this.cmbKhast.SelectionChangeCommitted += new System.EventHandler(this.cmbKhast_SelectionChangeCommitted);
            // 
            // cmbKilce
            // 
            this.cmbKilce.FormattingEnabled = true;
            this.cmbKilce.Location = new System.Drawing.Point(74, 84);
            this.cmbKilce.Name = "cmbKilce";
            this.cmbKilce.Size = new System.Drawing.Size(171, 21);
            this.cmbKilce.TabIndex = 1;
            this.cmbKilce.SelectedIndexChanged += new System.EventHandler(this.cmbKilce_SelectedIndexChanged);
            this.cmbKilce.SelectionChangeCommitted += new System.EventHandler(this.cmbKilce_SelectionChangeCommitted);
            // 
            // cmbKSehir
            // 
            this.cmbKSehir.FormattingEnabled = true;
            this.cmbKSehir.Location = new System.Drawing.Point(74, 39);
            this.cmbKSehir.Name = "cmbKSehir";
            this.cmbKSehir.Size = new System.Drawing.Size(171, 21);
            this.cmbKSehir.TabIndex = 0;
            this.cmbKSehir.SelectedIndexChanged += new System.EventHandler(this.cmbKSehir_SelectedIndexChanged);
            this.cmbKSehir.SelectionChangeCommitted += new System.EventHandler(this.cmbKSehir_SelectionChangeCommitted);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RANDEVULARIM";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // KullanıcıPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "KullanıcıPanel";
            this.Text = "KullanıcıPanel";
            this.Load += new System.EventHandler(this.KullanıcıPanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbKdoktor;
        private System.Windows.Forms.ComboBox cmbKklinik;
        private System.Windows.Forms.ComboBox cmbKhast;
        private System.Windows.Forms.ComboBox cmbKilce;
        private System.Windows.Forms.ComboBox cmbKSehir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}