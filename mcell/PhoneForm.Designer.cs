namespace mcell
{
    partial class PhoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneForm));
            this.listPhoneListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImeiEkle = new System.Windows.Forms.TextBox();
            this.buttonImeiEkle = new System.Windows.Forms.Button();
            this.buttonYenile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelModelEkle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxImeiAra = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.labelNot = new System.Windows.Forms.Label();
            this.textBoxNot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelKayitAdedi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPhoneListBox
            // 
            this.listPhoneListBox.FormattingEnabled = true;
            this.listPhoneListBox.HorizontalScrollbar = true;
            this.listPhoneListBox.ItemHeight = 24;
            this.listPhoneListBox.Location = new System.Drawing.Point(27, 152);
            this.listPhoneListBox.Name = "listPhoneListBox";
            this.listPhoneListBox.ScrollAlwaysVisible = true;
            this.listPhoneListBox.Size = new System.Drawing.Size(1884, 772);
            this.listPhoneListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imei Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2183, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imei Ekle";
            // 
            // textBoxImeiEkle
            // 
            this.textBoxImeiEkle.Location = new System.Drawing.Point(2141, 81);
            this.textBoxImeiEkle.Name = "textBoxImeiEkle";
            this.textBoxImeiEkle.Size = new System.Drawing.Size(260, 29);
            this.textBoxImeiEkle.TabIndex = 4;
            // 
            // buttonImeiEkle
            // 
            this.buttonImeiEkle.Location = new System.Drawing.Point(2221, 231);
            this.buttonImeiEkle.Name = "buttonImeiEkle";
            this.buttonImeiEkle.Size = new System.Drawing.Size(101, 43);
            this.buttonImeiEkle.TabIndex = 5;
            this.buttonImeiEkle.Text = "Ekle";
            this.buttonImeiEkle.UseVisualStyleBackColor = true;
            this.buttonImeiEkle.Click += new System.EventHandler(this.buttonImeiEkle_Click);
            // 
            // buttonYenile
            // 
            this.buttonYenile.Location = new System.Drawing.Point(35, 971);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(100, 51);
            this.buttonYenile.TabIndex = 6;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseMnemonic = false;
            this.buttonYenile.UseVisualStyleBackColor = true;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2042, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imei No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1979, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon Modeli";
            // 
            // textBoxTelModelEkle
            // 
            this.textBoxTelModelEkle.Location = new System.Drawing.Point(2141, 128);
            this.textBoxTelModelEkle.Name = "textBoxTelModelEkle";
            this.textBoxTelModelEkle.Size = new System.Drawing.Size(260, 29);
            this.textBoxTelModelEkle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Imei No";
            // 
            // textBoxImeiAra
            // 
            this.textBoxImeiAra.Location = new System.Drawing.Point(100, 76);
            this.textBoxImeiAra.Name = "textBoxImeiAra";
            this.textBoxImeiAra.Size = new System.Drawing.Size(207, 29);
            this.textBoxImeiAra.TabIndex = 10;
            this.textBoxImeiAra.TextChanged += new System.EventHandler(this.textBoxImeiAra_TextChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(157, 971);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(100, 51);
            this.buttonSil.TabIndex = 12;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseMnemonic = false;
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // labelNot
            // 
            this.labelNot.AutoSize = true;
            this.labelNot.Location = new System.Drawing.Point(2078, 185);
            this.labelNot.Name = "labelNot";
            this.labelNot.Size = new System.Drawing.Size(42, 25);
            this.labelNot.TabIndex = 14;
            this.labelNot.Text = "Not";
            // 
            // textBoxNot
            // 
            this.textBoxNot.Location = new System.Drawing.Point(2141, 185);
            this.textBoxNot.Name = "textBoxNot";
            this.textBoxNot.Size = new System.Drawing.Size(260, 29);
            this.textBoxNot.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 971);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kayıt Adedi:";
            // 
            // labelKayitAdedi
            // 
            this.labelKayitAdedi.AutoSize = true;
            this.labelKayitAdedi.Location = new System.Drawing.Point(551, 971);
            this.labelKayitAdedi.Name = "labelKayitAdedi";
            this.labelKayitAdedi.Size = new System.Drawing.Size(23, 25);
            this.labelKayitAdedi.TabIndex = 17;
            this.labelKayitAdedi.Text = "0";
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2465, 1177);
            this.Controls.Add(this.labelKayitAdedi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNot);
            this.Controls.Add(this.labelNot);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxImeiAra);
            this.Controls.Add(this.textBoxTelModelEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonYenile);
            this.Controls.Add(this.buttonImeiEkle);
            this.Controls.Add(this.textBoxImeiEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPhoneListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mcellImeiTakipForm";
            this.Load += new System.EventHandler(this.PhoneForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPhoneListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImeiEkle;
        private System.Windows.Forms.Button buttonImeiEkle;
        private System.Windows.Forms.Button buttonYenile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelModelEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxImeiAra;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label labelNot;
        private System.Windows.Forms.TextBox textBoxNot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelKayitAdedi;
    }
}

