namespace mcell
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
            this.SuspendLayout();
            // 
            // listPhoneListBox
            // 
            this.listPhoneListBox.FormattingEnabled = true;
            this.listPhoneListBox.ItemHeight = 24;
            this.listPhoneListBox.Location = new System.Drawing.Point(27, 152);
            this.listPhoneListBox.Name = "listPhoneListBox";
            this.listPhoneListBox.Size = new System.Drawing.Size(320, 316);
            this.listPhoneListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imei Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imei Ekle";
            // 
            // textBoxImeiEkle
            // 
            this.textBoxImeiEkle.Location = new System.Drawing.Point(622, 93);
            this.textBoxImeiEkle.Name = "textBoxImeiEkle";
            this.textBoxImeiEkle.Size = new System.Drawing.Size(207, 29);
            this.textBoxImeiEkle.TabIndex = 4;
            // 
            // buttonImeiEkle
            // 
            this.buttonImeiEkle.Location = new System.Drawing.Point(679, 215);
            this.buttonImeiEkle.Name = "buttonImeiEkle";
            this.buttonImeiEkle.Size = new System.Drawing.Size(101, 37);
            this.buttonImeiEkle.TabIndex = 5;
            this.buttonImeiEkle.Text = "Ekle";
            this.buttonImeiEkle.UseVisualStyleBackColor = true;
            this.buttonImeiEkle.Click += new System.EventHandler(this.buttonImeiEkle_Click);
            // 
            // buttonYenile
            // 
            this.buttonYenile.Location = new System.Drawing.Point(85, 488);
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
            this.label3.Location = new System.Drawing.Point(519, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imei No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon Modeli";
            // 
            // textBoxTelModelEkle
            // 
            this.textBoxTelModelEkle.Location = new System.Drawing.Point(622, 168);
            this.textBoxTelModelEkle.Name = "textBoxTelModelEkle";
            this.textBoxTelModelEkle.Size = new System.Drawing.Size(207, 29);
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
            this.textBoxImeiAra.Location = new System.Drawing.Point(125, 80);
            this.textBoxImeiAra.Name = "textBoxImeiAra";
            this.textBoxImeiAra.Size = new System.Drawing.Size(207, 29);
            this.textBoxImeiAra.TabIndex = 10;
            this.textBoxImeiAra.TextChanged += new System.EventHandler(this.textBoxImeiAra_TextChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(207, 488);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(100, 51);
            this.buttonSil.TabIndex = 12;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseMnemonic = false;
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 715);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

