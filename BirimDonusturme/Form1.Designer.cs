namespace BirimDonusturme
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Uzunluk = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uzunluk2_combobox = new System.Windows.Forms.ComboBox();
            this.uzunluk1_combobox = new System.Windows.Forms.ComboBox();
            this.Guc = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guc2_combobox = new System.Windows.Forms.ComboBox();
            this.guc1_combobox = new System.Windows.Forms.ComboBox();
            this.Basinc = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.basinc2_combobox = new System.Windows.Forms.ComboBox();
            this.basinc1_combobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.Uzunluk.SuspendLayout();
            this.Guc.SuspendLayout();
            this.Basinc.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Uzunluk);
            this.TabControl.Controls.Add(this.Guc);
            this.TabControl.Controls.Add(this.Basinc);
            this.TabControl.Location = new System.Drawing.Point(36, 27);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(490, 383);
            this.TabControl.TabIndex = 0;
            // 
            // Uzunluk
            // 
            this.Uzunluk.Controls.Add(this.textBox2);
            this.Uzunluk.Controls.Add(this.textBox1);
            this.Uzunluk.Controls.Add(this.label2);
            this.Uzunluk.Controls.Add(this.label1);
            this.Uzunluk.Controls.Add(this.uzunluk2_combobox);
            this.Uzunluk.Controls.Add(this.uzunluk1_combobox);
            this.Uzunluk.Location = new System.Drawing.Point(4, 25);
            this.Uzunluk.Name = "Uzunluk";
            this.Uzunluk.Padding = new System.Windows.Forms.Padding(3);
            this.Uzunluk.Size = new System.Drawing.Size(482, 354);
            this.Uzunluk.TabIndex = 0;
            this.Uzunluk.Text = "Uzunluk";
            this.Uzunluk.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // uzunluk2_combobox
            // 
            this.uzunluk2_combobox.FormattingEnabled = true;
            this.uzunluk2_combobox.Items.AddRange(new object[] {
            "metre",
            "inch",
            "foot",
            "yard",
            "kara mili"});
            this.uzunluk2_combobox.Location = new System.Drawing.Point(281, 85);
            this.uzunluk2_combobox.Name = "uzunluk2_combobox";
            this.uzunluk2_combobox.Size = new System.Drawing.Size(121, 24);
            this.uzunluk2_combobox.TabIndex = 0;
            this.uzunluk2_combobox.SelectedIndexChanged += new System.EventHandler(this.uzunluk2_combobox_SelectedIndexChanged);
            // 
            // uzunluk1_combobox
            // 
            this.uzunluk1_combobox.FormattingEnabled = true;
            this.uzunluk1_combobox.Items.AddRange(new object[] {
            "metre",
            "inch",
            "foot",
            "yard",
            "kara mili"});
            this.uzunluk1_combobox.Location = new System.Drawing.Point(78, 85);
            this.uzunluk1_combobox.Name = "uzunluk1_combobox";
            this.uzunluk1_combobox.Size = new System.Drawing.Size(121, 24);
            this.uzunluk1_combobox.TabIndex = 0;
            this.uzunluk1_combobox.SelectedIndexChanged += new System.EventHandler(this.uzunluk1_combobox_SelectedIndexChanged);
            // 
            // Guc
            // 
            this.Guc.Controls.Add(this.textBox3);
            this.Guc.Controls.Add(this.textBox4);
            this.Guc.Controls.Add(this.label3);
            this.Guc.Controls.Add(this.label4);
            this.Guc.Controls.Add(this.guc2_combobox);
            this.Guc.Controls.Add(this.guc1_combobox);
            this.Guc.Location = new System.Drawing.Point(4, 25);
            this.Guc.Name = "Guc";
            this.Guc.Padding = new System.Windows.Forms.Padding(3);
            this.Guc.Size = new System.Drawing.Size(482, 354);
            this.Guc.TabIndex = 1;
            this.Guc.Text = "Güç";
            this.Guc.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(269, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(269, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // guc2_combobox
            // 
            this.guc2_combobox.FormattingEnabled = true;
            this.guc2_combobox.Items.AddRange(new object[] {
            "kgf. m/s",
            "Kw",
            "Kcal/s",
            "PS"});
            this.guc2_combobox.Location = new System.Drawing.Point(282, 84);
            this.guc2_combobox.Name = "guc2_combobox";
            this.guc2_combobox.Size = new System.Drawing.Size(121, 24);
            this.guc2_combobox.TabIndex = 3;
            this.guc2_combobox.SelectedIndexChanged += new System.EventHandler(this.guc2_combobox_SelectedIndexChanged);
            // 
            // guc1_combobox
            // 
            this.guc1_combobox.FormattingEnabled = true;
            this.guc1_combobox.Items.AddRange(new object[] {
            "kgf. m/s",
            "Kw",
            "Kcal/s",
            "PS"});
            this.guc1_combobox.Location = new System.Drawing.Point(79, 84);
            this.guc1_combobox.Name = "guc1_combobox";
            this.guc1_combobox.Size = new System.Drawing.Size(121, 24);
            this.guc1_combobox.TabIndex = 4;
            this.guc1_combobox.SelectedIndexChanged += new System.EventHandler(this.guc1_combobox_SelectedIndexChanged);
            // 
            // Basinc
            // 
            this.Basinc.Controls.Add(this.textBox5);
            this.Basinc.Controls.Add(this.textBox6);
            this.Basinc.Controls.Add(this.label5);
            this.Basinc.Controls.Add(this.label6);
            this.Basinc.Controls.Add(this.basinc2_combobox);
            this.Basinc.Controls.Add(this.basinc1_combobox);
            this.Basinc.Location = new System.Drawing.Point(4, 25);
            this.Basinc.Name = "Basinc";
            this.Basinc.Padding = new System.Windows.Forms.Padding(3);
            this.Basinc.Size = new System.Drawing.Size(482, 354);
            this.Basinc.TabIndex = 2;
            this.Basinc.Text = "Basınç";
            this.Basinc.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(269, 249);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(269, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 8;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // basinc2_combobox
            // 
            this.basinc2_combobox.FormattingEnabled = true;
            this.basinc2_combobox.Items.AddRange(new object[] {
            "atm",
            "psi",
            "bar"});
            this.basinc2_combobox.Location = new System.Drawing.Point(282, 84);
            this.basinc2_combobox.Name = "basinc2_combobox";
            this.basinc2_combobox.Size = new System.Drawing.Size(121, 24);
            this.basinc2_combobox.TabIndex = 3;
            this.basinc2_combobox.SelectedIndexChanged += new System.EventHandler(this.basinc2_combobox_SelectedIndexChanged);
            // 
            // basinc1_combobox
            // 
            this.basinc1_combobox.FormattingEnabled = true;
            this.basinc1_combobox.Items.AddRange(new object[] {
            "atm",
            "psi",
            "bar"});
            this.basinc1_combobox.Location = new System.Drawing.Point(79, 84);
            this.basinc1_combobox.Name = "basinc1_combobox";
            this.basinc1_combobox.Size = new System.Drawing.Size(121, 24);
            this.basinc1_combobox.TabIndex = 4;
            this.basinc1_combobox.SelectedIndexChanged += new System.EventHandler(this.basinc1_combobox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Birim Dönüştürme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl.ResumeLayout(false);
            this.Uzunluk.ResumeLayout(false);
            this.Uzunluk.PerformLayout();
            this.Guc.ResumeLayout(false);
            this.Guc.PerformLayout();
            this.Basinc.ResumeLayout(false);
            this.Basinc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Uzunluk;
        private System.Windows.Forms.TabPage Guc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage Basinc;
        private System.Windows.Forms.ComboBox uzunluk2_combobox;
        private System.Windows.Forms.ComboBox uzunluk1_combobox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox guc2_combobox;
        private System.Windows.Forms.ComboBox guc1_combobox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox basinc2_combobox;
        private System.Windows.Forms.ComboBox basinc1_combobox;
    }
}

