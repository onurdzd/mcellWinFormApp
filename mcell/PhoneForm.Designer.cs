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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxImeiEkle = new System.Windows.Forms.TextBox();
            this.buttonImeiEkle = new System.Windows.Forms.Button();
            this.buttonYenile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTelModelEkle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.labelNot = new System.Windows.Forms.Label();
            this.textBoxNot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelKayitAdedi = new System.Windows.Forms.Label();
            this.dataGridViewPhoneList = new System.Windows.Forms.DataGridView();
            this.buttonSifirla = new System.Windows.Forms.Button();
            this.textBoxKullanimSuresi = new System.Windows.Forms.TextBox();
            this.textBoxKullanimHakki = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxImeiAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1272, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama Yap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(622, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon Ekle";
            // 
            // textBoxImeiEkle
            // 
            this.textBoxImeiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImeiEkle.Location = new System.Drawing.Point(604, 89);
            this.textBoxImeiEkle.Name = "textBoxImeiEkle";
            this.textBoxImeiEkle.Size = new System.Drawing.Size(260, 37);
            this.textBoxImeiEkle.TabIndex = 1;
            // 
            // buttonImeiEkle
            // 
            this.buttonImeiEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonImeiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImeiEkle.Location = new System.Drawing.Point(652, 360);
            this.buttonImeiEkle.Name = "buttonImeiEkle";
            this.buttonImeiEkle.Size = new System.Drawing.Size(166, 56);
            this.buttonImeiEkle.TabIndex = 6;
            this.buttonImeiEkle.Text = "Ekle";
            this.buttonImeiEkle.UseVisualStyleBackColor = false;
            this.buttonImeiEkle.Click += new System.EventHandler(this.buttonImeiEkle_Click);
            // 
            // buttonYenile
            // 
            this.buttonYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYenile.Location = new System.Drawing.Point(358, 1085);
            this.buttonYenile.Name = "buttonYenile";
            this.buttonYenile.Size = new System.Drawing.Size(100, 51);
            this.buttonYenile.TabIndex = 7;
            this.buttonYenile.Text = "Yenile";
            this.buttonYenile.UseMnemonic = false;
            this.buttonYenile.UseVisualStyleBackColor = false;
            this.buttonYenile.Click += new System.EventHandler(this.buttonYenile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imei No ***";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon Modeli ***";
            // 
            // textBoxTelModelEkle
            // 
            this.textBoxTelModelEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelModelEkle.Location = new System.Drawing.Point(604, 136);
            this.textBoxTelModelEkle.Name = "textBoxTelModelEkle";
            this.textBoxTelModelEkle.Size = new System.Drawing.Size(260, 37);
            this.textBoxTelModelEkle.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1142, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Imei No :";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSil.Location = new System.Drawing.Point(480, 1085);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(100, 51);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseMnemonic = false;
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // labelNot
            // 
            this.labelNot.AutoSize = true;
            this.labelNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNot.Location = new System.Drawing.Point(507, 305);
            this.labelNot.Name = "labelNot";
            this.labelNot.Size = new System.Drawing.Size(56, 30);
            this.labelNot.TabIndex = 14;
            this.labelNot.Text = "Not";
            // 
            // textBoxNot
            // 
            this.textBoxNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNot.Location = new System.Drawing.Point(604, 305);
            this.textBoxNot.Name = "textBoxNot";
            this.textBoxNot.Size = new System.Drawing.Size(260, 37);
            this.textBoxNot.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1879, 1091);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kayıt Adedi:";
            // 
            // labelKayitAdedi
            // 
            this.labelKayitAdedi.AutoSize = true;
            this.labelKayitAdedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKayitAdedi.Location = new System.Drawing.Point(2064, 1091);
            this.labelKayitAdedi.Name = "labelKayitAdedi";
            this.labelKayitAdedi.Size = new System.Drawing.Size(31, 32);
            this.labelKayitAdedi.TabIndex = 17;
            this.labelKayitAdedi.Text = "0";
            // 
            // dataGridViewPhoneList
            // 
            this.dataGridViewPhoneList.AllowUserToOrderColumns = true;
            this.dataGridViewPhoneList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewPhoneList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPhoneList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPhoneList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPhoneList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPhoneList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhoneList.Location = new System.Drawing.Point(364, 459);
            this.dataGridViewPhoneList.Name = "dataGridViewPhoneList";
            this.dataGridViewPhoneList.RowHeadersWidth = 72;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPhoneList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPhoneList.RowTemplate.Height = 31;
            this.dataGridViewPhoneList.Size = new System.Drawing.Size(2082, 573);
            this.dataGridViewPhoneList.TabIndex = 18;
            this.dataGridViewPhoneList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhoneList_CellClick);
            this.dataGridViewPhoneList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPhoneList_CellValueChanged);
            // 
            // buttonSifirla
            // 
            this.buttonSifirla.BackColor = System.Drawing.Color.Red;
            this.buttonSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSifirla.Location = new System.Drawing.Point(2225, 1085);
            this.buttonSifirla.Name = "buttonSifirla";
            this.buttonSifirla.Size = new System.Drawing.Size(121, 51);
            this.buttonSifirla.TabIndex = 9;
            this.buttonSifirla.Text = "SIFIRLA";
            this.buttonSifirla.UseMnemonic = false;
            this.buttonSifirla.UseVisualStyleBackColor = false;
            this.buttonSifirla.Click += new System.EventHandler(this.buttonSifirla_Click);
            // 
            // textBoxKullanimSuresi
            // 
            this.textBoxKullanimSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKullanimSuresi.Location = new System.Drawing.Point(604, 190);
            this.textBoxKullanimSuresi.Name = "textBoxKullanimSuresi";
            this.textBoxKullanimSuresi.Size = new System.Drawing.Size(260, 37);
            this.textBoxKullanimSuresi.TabIndex = 3;
            // 
            // textBoxKullanimHakki
            // 
            this.textBoxKullanimHakki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKullanimHakki.Location = new System.Drawing.Point(604, 249);
            this.textBoxKullanimHakki.Name = "textBoxKullanimHakki";
            this.textBoxKullanimHakki.Size = new System.Drawing.Size(260, 37);
            this.textBoxKullanimHakki.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "Kullanım Süresi (Gün)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(282, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Kullanım Hakkı (Adet)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(389, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "*** (Zorunlu alan)";
            // 
            // textBoxImeiAra
            // 
            this.textBoxImeiAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImeiAra.Location = new System.Drawing.Point(1270, 414);
            this.textBoxImeiAra.Name = "textBoxImeiAra";
            this.textBoxImeiAra.Size = new System.Drawing.Size(207, 37);
            this.textBoxImeiAra.TabIndex = 25;
            this.textBoxImeiAra.TextChanged += new System.EventHandler(this.textBoxImeiAra_TextChanged_1);
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2812, 1311);
            this.Controls.Add(this.textBoxImeiAra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKullanimHakki);
            this.Controls.Add(this.textBoxKullanimSuresi);
            this.Controls.Add(this.buttonSifirla);
            this.Controls.Add(this.dataGridViewPhoneList);
            this.Controls.Add(this.labelKayitAdedi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNot);
            this.Controls.Add(this.labelNot);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTelModelEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonYenile);
            this.Controls.Add(this.buttonImeiEkle);
            this.Controls.Add(this.textBoxImeiEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mcell Imei Takip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PhoneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxImeiEkle;
        private System.Windows.Forms.Button buttonImeiEkle;
        private System.Windows.Forms.Button buttonYenile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelModelEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label labelNot;
        private System.Windows.Forms.TextBox textBoxNot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelKayitAdedi;
        private System.Windows.Forms.DataGridView dataGridViewPhoneList;
        private System.Windows.Forms.Button buttonSifirla;
        private System.Windows.Forms.TextBox textBoxKullanimSuresi;
        private System.Windows.Forms.TextBox textBoxKullanimHakki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxImeiAra;
    }
}

