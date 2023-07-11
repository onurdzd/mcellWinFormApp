﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mcell
{ //kullanım hakkı eklenecek,cell bazlı edit eklenecek,kalan gün sayisi güncellenmiyor 
    public partial class PhoneForm : Form
    {
        List<PhoneModel>phoneGridList=new List<PhoneModel>();
        int selectedRowId = 0;
        public PhoneForm()
        {
            InitializeComponent();
            LoadPhoneGridList();
        }
        private void LoadPhoneGridList()
        {
            phoneGridList = SqliteDataAccess.LoadGridPhones();
            dataGridViewPhoneList.DataSource = phoneGridList;
            labelKayitAdedi.Text = Convert.ToString(phoneGridList.Count);
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            LoadPhoneGridList();
        }

        private void buttonImeiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                PhoneModel foundPhone = phoneGridList.Find(phone => phone.imei == Convert.ToInt64(textBoxImeiEkle.Text));

                if (string.IsNullOrEmpty(textBoxImeiEkle.Text) || string.IsNullOrEmpty(textBoxTelModelEkle.Text))
                {
                    MessageBox.Show("Imei no veya Telefon Modeli eksik girildi");
                }
                else if ((textBoxImeiEkle.Text).Length != 15)
                {
                    MessageBox.Show("Imei no 15 karakterden oluşmalıdır!");
                }
                else if (foundPhone!=null)
                {
                    MessageBox.Show("Imei listede buluyor. Farklı imei girin!");
                }
                else
                {
                    int kullanimSuresi;
                    int kullanimHakki;

                    if (string.IsNullOrEmpty(textBoxKullanimSuresi.Text))
                    {
                        kullanimSuresi = 365;
                    }
                    else
                    {
                        kullanimSuresi = Convert.ToInt32(textBoxKullanimSuresi.Text);
                    }
                    if (string.IsNullOrEmpty(textBoxKullanimHakki.Text))
                    {
                        kullanimHakki = 10;
                    }
                    else
                    {
                        kullanimHakki = Convert.ToInt32(textBoxKullanimHakki.Text);
                    }


                    PhoneModel p = new PhoneModel(0, Convert.ToInt64(textBoxImeiEkle.Text), textBoxTelModelEkle.Text,DateTime.Now.Date, DateTime.Now.Date.AddDays(kullanimSuresi), kullanimSuresi, kullanimHakki, 0, textBoxNot.Text);
                    SqliteDataAccess.SavePhone(p);
                    MessageBox.Show($"{p.imei} listeye eklendi!");
                    LoadPhoneGridList();
                    textBoxImeiEkle.Text = "";
                    textBoxTelModelEkle.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Imei no veya Telefon Modeli Hatalı Formatta Girildi");
            }
        }

        private void textBoxImeiAra_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxImeiAra.Text;
            List<PhoneModel> filteredData = new List<PhoneModel>();

            foreach (var item in phoneGridList)
            {
                if (item.imei.ToString().Contains(searchText) || item.phoneModel.ToString().Contains(searchText))
                {
                    filteredData.Add(item);
                }
            }
          
            dataGridViewPhoneList.DataSource = filteredData;

            if (textBoxImeiAra.Text == "")
            {
                LoadPhoneGridList();
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {

            if (selectedRowId > 0)
            {
                DialogResult result = MessageBox.Show("Seçilen satırı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    PhoneModel pgrid = phoneGridList.FirstOrDefault(x => x.id == selectedRowId);
                    SqliteDataAccess.DeletePhone(pgrid);
                    LoadPhoneGridList();

                    MessageBox.Show("Satır başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
          
        private void dataGridViewPhoneList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           /* DataGridView dataGridView = (DataGridView)sender;
            DataGridViewCell selectedCell = dataGridView.CurrentCell;
            int columnIndex = selectedCell.ColumnIndex;
            string columnName = dataGridView.Columns[columnIndex].Name;
            MessageBox.Show($" {columnName}");

            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            string newValue = row.Cells[e.ColumnIndex].Value.ToString();*/
        }

        private void dataGridViewPhoneList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                selectedRowId = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
        }

        private void buttonSifirla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Veritabanını sıfırlamak istediğinizden emin misiniz? Bu işlem geri alınamaz!", "Sıfırlama Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Veritabanı sıfırlama işlemini gerçekleştirin
                SqliteDataAccess.ResetDb();

                MessageBox.Show("Veritabanı sıfırlama işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhoneGridList();
            }
        }
    }
}
