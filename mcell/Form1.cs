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
    public partial class Form1 : Form
    {
        List<PhoneModel>phone=new List<PhoneModel>();
        public Form1()
        {
            InitializeComponent();
            LoadPhoneList();
        }

        private void LoadPhoneList()
        {
            WireUpPhoneList();
        }

        private void WireUpPhoneList()
        {
            listPhoneListBox.DataSource = null;
            listPhoneListBox.DataSource = phone;
            listPhoneListBox.DisplayMember = "FullDetails";

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
                PhoneModel p = new PhoneModel(Convert.ToInt32(textBoxImeiEkle.Text), textBoxTelModelEkle.Text);
                phone.Add(p);
                LoadPhoneList();
                textBoxImeiEkle.Text = "";
                textBoxTelModelEkle.Text = "";
            }
            }catch {
                MessageBox.Show("Imei no veya Telefon Modeli Hatalı Formatta Girildi");
            }
        }

        private void buttonYenile_Click(object sender, EventArgs e)
        {
            LoadPhoneList();
        }

        private void textBoxImeiAra_TextChanged(object sender, EventArgs e)
        {
            listPhoneListBox.DataSource = null;
            string searchText = textBoxImeiAra.Text;
            List<PhoneModel> filteredData = new List<PhoneModel>();

            foreach (var item in phone)
            {
                if (item.imei.ToString().Contains(searchText) || item.phoneName.ToString().Contains(searchText))
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
    }
}
