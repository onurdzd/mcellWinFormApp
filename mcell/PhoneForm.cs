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
        public PhoneForm()
        {
            InitializeComponent();
            LoadPhoneList();
        }

        private void LoadPhoneList()
        {   
            listPhoneListBox.DataSource = null;
            phoneList = SqliteDataAccess.LoadPhones();
            listPhoneListBox.DataSource = phoneList;
            listPhoneListBox.DisplayMember = "FullDetails";
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            LoadPhoneList();
        }

        private void buttonImeiEkle_Click(object sender, EventArgs e)
        {
            try { 
            if (string.IsNullOrEmpty(textBoxImeiEkle.Text) || string.IsNullOrEmpty(textBoxTelModelEkle.Text))
            {
                MessageBox.Show("Imei no veya Telefon Modeli Eksik girildi");
            }
            else
            {
                PhoneModel p = new PhoneModel(Convert.ToInt64(textBoxImeiEkle.Text), textBoxTelModelEkle.Text,textBoxNot.Text);
                    SqliteDataAccess.SavePhone(p);
                    MessageBox.Show($"{p} listeye eklendi!");
                    LoadPhoneList();
                    textBoxImeiEkle.Text = "";
                    textBoxTelModelEkle.Text = "";
            }
            }catch {
                MessageBox.Show("Imei no veya Telefon Modeli Hatalı Formatta Girildi");
            }
        }


        private void textBoxImeiAra_TextChanged(object sender, EventArgs e)
        {
            listPhoneListBox.DataSource = null;
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

            if (textBoxImeiAra.Text == "")
            {
                LoadPhoneList();
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            int selectedIndex = listPhoneListBox.SelectedIndex;

            if (selectedIndex >= 0)
            {
                phoneList.RemoveAt(selectedIndex);
                LoadPhoneList();
            }
        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {

        }
    }
}
