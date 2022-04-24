namespace IdealKiloHesabi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boy_textbox = new System.Windows.Forms.TextBox();
            this.dogumyili_textbox = new System.Windows.Forms.TextBox();
            this.kilo_textbox = new System.Windows.Forms.TextBox();
            this.idealkilo_textbox = new System.Windows.Forms.TextBox();
            this.bilgi_label = new System.Windows.Forms.Label();
            this.hesapla_button = new System.Windows.Forms.Button();
            this.son_button = new System.Windows.Forms.Button();
            this.cinsiyet_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doğum Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kilo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "İdeal Kilo";
            // 
            // boy_textbox
            // 
            this.boy_textbox.Location = new System.Drawing.Point(257, 50);
            this.boy_textbox.Name = "boy_textbox";
            this.boy_textbox.Size = new System.Drawing.Size(137, 22);
            this.boy_textbox.TabIndex = 1;
            // 
            // dogumyili_textbox
            // 
            this.dogumyili_textbox.Location = new System.Drawing.Point(257, 114);
            this.dogumyili_textbox.Name = "dogumyili_textbox";
            this.dogumyili_textbox.Size = new System.Drawing.Size(137, 22);
            this.dogumyili_textbox.TabIndex = 1;
            // 
            // kilo_textbox
            // 
            this.kilo_textbox.Location = new System.Drawing.Point(257, 238);
            this.kilo_textbox.Name = "kilo_textbox";
            this.kilo_textbox.Size = new System.Drawing.Size(137, 22);
            this.kilo_textbox.TabIndex = 1;
            // 
            // idealkilo_textbox
            // 
            this.idealkilo_textbox.Location = new System.Drawing.Point(257, 335);
            this.idealkilo_textbox.Name = "idealkilo_textbox";
            this.idealkilo_textbox.ReadOnly = true;
            this.idealkilo_textbox.Size = new System.Drawing.Size(137, 22);
            this.idealkilo_textbox.TabIndex = 1;
            // 
            // bilgi_label
            // 
            this.bilgi_label.AutoSize = true;
            this.bilgi_label.Location = new System.Drawing.Point(124, 428);
            this.bilgi_label.Name = "bilgi_label";
            this.bilgi_label.Size = new System.Drawing.Size(0, 16);
            this.bilgi_label.TabIndex = 2;
            // 
            // hesapla_button
            // 
            this.hesapla_button.Location = new System.Drawing.Point(100, 494);
            this.hesapla_button.Name = "hesapla_button";
            this.hesapla_button.Size = new System.Drawing.Size(90, 35);
            this.hesapla_button.TabIndex = 3;
            this.hesapla_button.Text = "Hesapla";
            this.hesapla_button.UseVisualStyleBackColor = true;
            this.hesapla_button.Click += new System.EventHandler(this.hesapla_button_Click);
            // 
            // son_button
            // 
            this.son_button.Location = new System.Drawing.Point(290, 494);
            this.son_button.Name = "son_button";
            this.son_button.Size = new System.Drawing.Size(90, 35);
            this.son_button.TabIndex = 3;
            this.son_button.Text = "Son";
            this.son_button.UseVisualStyleBackColor = true;
            this.son_button.Click += new System.EventHandler(this.son_button_Click);
            // 
            // cinsiyet_combobox
            // 
            this.cinsiyet_combobox.FormattingEnabled = true;
            this.cinsiyet_combobox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyet_combobox.Location = new System.Drawing.Point(257, 174);
            this.cinsiyet_combobox.Name = "cinsiyet_combobox";
            this.cinsiyet_combobox.Size = new System.Drawing.Size(137, 24);
            this.cinsiyet_combobox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 559);
            this.Controls.Add(this.cinsiyet_combobox);
            this.Controls.Add(this.son_button);
            this.Controls.Add(this.hesapla_button);
            this.Controls.Add(this.bilgi_label);
            this.Controls.Add(this.idealkilo_textbox);
            this.Controls.Add(this.kilo_textbox);
            this.Controls.Add(this.dogumyili_textbox);
            this.Controls.Add(this.boy_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "İdeal Kilo Hesabı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boy_textbox;
        private System.Windows.Forms.TextBox dogumyili_textbox;
        private System.Windows.Forms.TextBox kilo_textbox;
        private System.Windows.Forms.TextBox idealkilo_textbox;
        private System.Windows.Forms.Label bilgi_label;
        private System.Windows.Forms.Button hesapla_button;
        private System.Windows.Forms.Button son_button;
        private System.Windows.Forms.ComboBox cinsiyet_combobox;
    }
}

