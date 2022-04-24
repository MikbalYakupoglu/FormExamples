namespace ResmiTatilGunleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.ekle = new System.Windows.Forms.Button();
            this.cikar = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resmi Tatiller";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resmi Tatil Günleri";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yılbaşı",
            "Ulusal Egemenlik ve Çocuk Bayramı",
            "Emek ve Dayanışma Günü",
            "Ramazan Bayramı",
            "Atatürk\'ü Anma, Gençlik ve Spor Bayramı",
            "Kurban Bayramı",
            "Demokrasi Bayramı",
            "Zafer Bayramı",
            "Cumhuriyet Bayramı"});
            this.comboBox1.Location = new System.Drawing.Point(33, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Enabled = false;
            this.monthCalendar1.Location = new System.Drawing.Point(33, 168);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(388, 171);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(102, 38);
            this.ekle.TabIndex = 4;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // cikar
            // 
            this.cikar.Location = new System.Drawing.Point(388, 247);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(102, 38);
            this.cikar.TabIndex = 4;
            this.cikar.Text = "Çıkar";
            this.cikar.UseVisualStyleBackColor = true;
            this.cikar.Click += new System.EventHandler(this.cikar_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(388, 321);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(102, 38);
            this.cikis.TabIndex = 4;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(522, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 260);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 452);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.cikar);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Resmi Tatil Günleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.ListBox listBox1;
    }
}

