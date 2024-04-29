namespace NDP_homework2 {
    partial class Form1 {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuKaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.çalışanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanÇıkarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Randevu ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Müşteri ismi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri soyismi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aktif Randevular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hizmet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ekstralar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(87, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Saç";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(164, 177);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 20);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Sakal";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(87, 214);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 20);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Yıkama";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(164, 214);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 20);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Jöle/parfüm";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 356);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tarih";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Saat";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00"});
            this.comboBox1.Location = new System.Drawing.Point(107, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Müşteri Tel No";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 19;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanlarToolStripMenuItem,
            this.randevularToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 30);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randevularToolStripMenuItem
            // 
            this.randevularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuDüzenleToolStripMenuItem,
            this.randevuKaldırToolStripMenuItem});
            this.randevularToolStripMenuItem.Name = "randevularToolStripMenuItem";
            this.randevularToolStripMenuItem.Size = new System.Drawing.Size(97, 26);
            this.randevularToolStripMenuItem.Text = "Randevular";
            // 
            // randevuDüzenleToolStripMenuItem
            // 
            this.randevuDüzenleToolStripMenuItem.Name = "randevuDüzenleToolStripMenuItem";
            this.randevuDüzenleToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.randevuDüzenleToolStripMenuItem.Text = "Randevu Düzenle";
            this.randevuDüzenleToolStripMenuItem.Click += new System.EventHandler(this.randevuDüzenleToolStripMenuItem_Click);
            // 
            // randevuKaldırToolStripMenuItem
            // 
            this.randevuKaldırToolStripMenuItem.Name = "randevuKaldırToolStripMenuItem";
            this.randevuKaldırToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.randevuKaldırToolStripMenuItem.Text = "Randevu Kaldır";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Location = new System.Drawing.Point(279, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(510, 332);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // çalışanEkleToolStripMenuItem
            // 
            this.çalışanEkleToolStripMenuItem.Name = "çalışanEkleToolStripMenuItem";
            this.çalışanEkleToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.çalışanEkleToolStripMenuItem.Text = "Çalışan Ekle";
            this.çalışanEkleToolStripMenuItem.Click += new System.EventHandler(this.çalışanEkleToolStripMenuItem_Click);
            // 
            // çalışanÇıkarToolStripMenuItem
            // 
            this.çalışanÇıkarToolStripMenuItem.Name = "çalışanÇıkarToolStripMenuItem";
            this.çalışanÇıkarToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.çalışanÇıkarToolStripMenuItem.Text = "Çalışan Çıkar";
            this.çalışanÇıkarToolStripMenuItem.Click += new System.EventHandler(this.çalışanÇıkarToolStripMenuItem_Click);
            // 
            // çalışanlarıGüncelleToolStripMenuItem
            // 
            this.çalışanlarıGüncelleToolStripMenuItem.Name = "çalışanlarıGüncelleToolStripMenuItem";
            this.çalışanlarıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.çalışanlarıGüncelleToolStripMenuItem.Text = "Çalışanları Güncelle";
            this.çalışanlarıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.çalışanlarıGüncelleToolStripMenuItem_Click);
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çalışanEkleToolStripMenuItem,
            this.çalışanÇıkarToolStripMenuItem,
            this.çalışanlarıGüncelleToolStripMenuItem});
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.çalışanlarToolStripMenuItem.Text = "Çalışanlar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "Berber";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(107, 260);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 52;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(NDP_homework2.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(801, 476);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Randevu Kontrol Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuKaldırToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanÇıkarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarıGüncelleToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

