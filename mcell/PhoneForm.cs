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
{
    public partial class PhoneForm : Form
    {
        List<PhoneModel>phoneList=new List<PhoneModel>();
        List<PhoneModel>phoneGridList=new List<PhoneModel>();
        int selectedRowId = 0;
        public PhoneForm()
        {
            InitializeComponent();
            LoadPhoneList();
            LoadPhoneGridList();
        }

        private void LoadPhoneList()
        {   
            listPhoneListBox.DataSource = null;
            phoneList = SqliteDataAccess.LoadPhones();
            listPhoneListBox.DataSource = phoneList;
            listPhoneListBox.DisplayMember = "FullDetails";
            labelKayitAdedi.Text = Convert.ToString(phoneList.Count);
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            LoadPhoneList();
            LoadPhoneGridList();
        }

        private void buttonImeiEkle_Click(object sender, EventArgs e)
        {
            try { 
            if (string.IsNullOrEmpty(textBoxImeiEkle.Text) || (textBoxImeiEkle.Text).Length!=15 || string.IsNullOrEmpty(textBoxTelModelEkle.Text))
            {
                MessageBox.Show("Imei no veya Telefon Modeli Yanlış girildi");
            }
            else
            {
                PhoneModel p = new PhoneModel(0, Convert.ToInt64(textBoxImeiEkle.Text), textBoxTelModelEkle.Text, DateTime.Now, DateTime.Now.AddDays(365), 365, 10, 0, textBoxNot.Text);
                    SqliteDataAccess.SavePhone(p);
                    MessageBox.Show($"{p.imei} listeye eklendi!");
                    LoadPhoneList();
                    LoadPhoneGridList();
                    textBoxImeiEkle.Text = "";
                    textBoxTelModelEkle.Text = "";
                }
            }catch {
                MessageBox.Show("Imei no veya Telefon Modeli Hatalı Formatta Girildi");
            }
        }

        private void textBoxImeiAra_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxImeiAra.Text;
            List<PhoneModel> filteredData = new List<PhoneModel>();

            foreach (var item in phoneList)
            {
                if (item.imei.ToString().Contains(searchText) || item.phoneModel.ToString().Contains(searchText))
                {
                    filteredData.Add(item);
                }
            }

            listPhoneListBox.DataSource = filteredData;
            listPhoneListBox.DisplayMember = "FullDetails";
            dataGridViewPhoneList.DataSource = filteredData;

            if (textBoxImeiAra.Text == "")
            {
                LoadPhoneList();
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
                    /*PhoneModel p = (PhoneModel)listPhoneListBox.SelectedValue;
                    SqliteDataAccess.DeletePhone(p);
                    MessageBox.Show($"{p.imei} imei nolu telefon listeden silindi! ");
                    LoadPhoneList();*/

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

        /// 
        /// //////GRID AREA
        /// 

        private void LoadPhoneGridList()
        {
            phoneGridList = SqliteDataAccess.LoadGridPhones();
            dataGridViewPhoneList.DataSource = phoneGridList;
            labelKayitAdedi.Text = Convert.ToString(phoneList.Count);
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
    }
}
