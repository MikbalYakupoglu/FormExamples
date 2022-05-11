namespace SiparisListesi
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
            this.kitaplistesi_checkbox = new System.Windows.Forms.CheckedListBox();
            this.siparislistesi_button = new System.Windows.Forms.Button();
            this.son_button = new System.Windows.Forms.Button();
            this.siparislistesi_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sipariş Listesi";
            // 
            // kitaplistesi_checkbox
            // 
            this.kitaplistesi_checkbox.FormattingEnabled = true;
            this.kitaplistesi_checkbox.Items.AddRange(new object[] {
            "Üç Silahşörler",
            "Define Adası",
            "İnsan Neyle Yaşar",
            "Heidi",
            "Pinokyo",
            "Değirmenden Mektuplar",
            "Hikayeler",
            "Nasreddin Hoca",
            "İki Şehrin Hikayesi",
            "Oliver Twist",
            "Yalnız Efe",
            "Beyaz Diş",
            "Robin Hood",
            "Seksen Günde Dünya Turu"});
            this.kitaplistesi_checkbox.Location = new System.Drawing.Point(94, 133);
            this.kitaplistesi_checkbox.Name = "kitaplistesi_checkbox";
            this.kitaplistesi_checkbox.Size = new System.Drawing.Size(219, 191);
            this.kitaplistesi_checkbox.TabIndex = 1;
            // 
            // siparislistesi_button
            // 
            this.siparislistesi_button.Location = new System.Drawing.Point(175, 382);
            this.siparislistesi_button.Name = "siparislistesi_button";
            this.siparislistesi_button.Size = new System.Drawing.Size(150, 39);
            this.siparislistesi_button.TabIndex = 3;
            this.siparislistesi_button.Text = "Sipariş Listesi";
            this.siparislistesi_button.UseVisualStyleBackColor = true;
            this.siparislistesi_button.Click += new System.EventHandler(this.siparislistesi_button_Click);
            // 
            // son_button
            // 
            this.son_button.Location = new System.Drawing.Point(455, 382);
            this.son_button.Name = "son_button";
            this.son_button.Size = new System.Drawing.Size(150, 39);
            this.son_button.TabIndex = 3;
            this.son_button.Text = "Son";
            this.son_button.UseVisualStyleBackColor = true;
            this.son_button.Click += new System.EventHandler(this.son_button_Click);
            // 
            // siparislistesi_listbox
            // 
            this.siparislistesi_listbox.FormattingEnabled = true;
            this.siparislistesi_listbox.ItemHeight = 16;
            this.siparislistesi_listbox.Location = new System.Drawing.Point(473, 128);
            this.siparislistesi_listbox.Name = "siparislistesi_listbox";
            this.siparislistesi_listbox.Size = new System.Drawing.Size(197, 196);
            this.siparislistesi_listbox.TabIndex = 4;
            this.siparislistesi_listbox.DoubleClick += new System.EventHandler(this.siparislistesi_listbox_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siparislistesi_listbox);
            this.Controls.Add(this.son_button);
            this.Controls.Add(this.siparislistesi_button);
            this.Controls.Add(this.kitaplistesi_checkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SiparisListesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox kitaplistesi_checkbox;
        private System.Windows.Forms.Button siparislistesi_button;
        private System.Windows.Forms.Button son_button;
        private System.Windows.Forms.ListBox siparislistesi_listbox;
    }
}

