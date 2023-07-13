using System;
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

        private void ApplyCellStyles()
        {
            foreach (DataGridViewRow row in dataGridViewPhoneList.Rows)
            {
                string targetColumn = "kullanilanHak"; // Güncellenecek hedef sütun adı

                if (dataGridViewPhoneList.Columns.Contains(targetColumn))
                {
                    DataGridViewColumn column = dataGridViewPhoneList.Columns[targetColumn];
                    DataGridViewCellStyle DefaultCellStyle = column.DefaultCellStyle;
                    DefaultCellStyle.BackColor = Color.DarkGray; // Hedef sütunun arka plan rengini kırmızı olarak güncelle
                }
                // Sütun adlarını kullanarak hücre değerlerini alın
                string kalanGunSayisiStr = row.Cells["kalanGunSayisi"].Value.ToString();
                string kalanKullanimHakkiStr = row.Cells["kalanKullanimHakki"].Value.ToString();

                // Hücre değerlerini uygun türe dönüştürün
                int kalanGunSayisi = int.Parse(kalanGunSayisiStr);
                int kalanKullanimHakki = int.Parse(kalanKullanimHakkiStr);

                // Hücreleri renklendirme
                DataGridViewCellStyle cellStyle = row.Cells["kalanGunSayisi"].Style;
                if (kalanGunSayisi > 30 && kalanGunSayisi < 91)
                {
                    cellStyle.BackColor = Color.Yellow;
                }
                else if (kalanGunSayisi < 31)
                {
                    cellStyle.BackColor = Color.Red;
                }
                else
                {
                    cellStyle.BackColor = Color.Green;
                }

                cellStyle = row.Cells["kalanKullanimHakki"].Style;
                if (kalanKullanimHakki>2 && kalanKullanimHakki < 6)
                {
                    cellStyle.BackColor = Color.Yellow;
                }
                else if (kalanKullanimHakki < 3)
                {
                    cellStyle.BackColor = Color.Red;
                }
                else
                {
                    cellStyle.BackColor = Color.Green;
                }
            }
        }
        private void LoadPhoneGridList()
        {
            phoneGridList = SqliteDataAccess.LoadGridPhones();
            foreach (PhoneModel phone in phoneGridList)
            {
                DateTime baslangicTarihi = DateTime.Now;
                DateTime sonKullanimTarihi = phone.sonKullanimTarihi;
                TimeSpan gunFarki = sonKullanimTarihi.Date - baslangicTarihi.Date;
                int kalanGunSayisi = gunFarki.Days;

                phone.kalanGunSayisi = kalanGunSayisi;

                SqliteDataAccess.UpdatePhone(phone);
            }
            dataGridViewPhoneList.DataSource = phoneGridList;
            ApplyCellStyles();
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
                    int kalanKullanimHakki;

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
                        kalanKullanimHakki = 10;
                    }
                    else
                    {
                        kalanKullanimHakki = Convert.ToInt32(textBoxKullanimHakki.Text);
                    }

                    PhoneModel p = new PhoneModel(0, Convert.ToInt64(textBoxImeiEkle.Text), textBoxTelModelEkle.Text,DateTime.Now.Date, DateTime.Now.Date.AddDays(kullanimSuresi), kullanimSuresi, kalanKullanimHakki, 0, textBoxNot.Text);
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
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                PhoneModel phone = new PhoneModel(
                    Convert.ToInt64(selectedRow.Cells["id"].Value),
                    Convert.ToInt64(selectedRow.Cells["imei"].Value),
                    selectedRow.Cells["phoneModel"].Value.ToString(),
                    Convert.ToDateTime(selectedRow.Cells["baslangicTarihi"].Value),
                    Convert.ToDateTime(selectedRow.Cells["sonKullanimTarihi"].Value),
                    Convert.ToInt64(selectedRow.Cells["kalanGunSayisi"].Value),
                    Convert.ToInt64(selectedRow.Cells["kalanKullanimHakki"].Value),
                    Convert.ToInt64(selectedRow.Cells["kullanilanHak"].Value),
                    selectedRow.Cells["notlar"].Value.ToString());

                SqliteDataAccess.UpdatePhone(phone);
                LoadPhoneGridList();
            }
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
                SqliteDataAccess.ResetDb();

                MessageBox.Show("Veritabanı sıfırlama işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhoneGridList();
            }
        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {
            ApplyCellStyles();
        }
    }
}
