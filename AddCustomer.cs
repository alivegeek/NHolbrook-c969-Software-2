using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHolbrook_c969_Software_2
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void labelCustomer_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // create a customer object
           // int custID = App.GetNewCustomerID();






            Customer customer = new Customer(
                                                  inputName.Text,
                                                  comboBox1.SelectedIndex, //future me make this a required field
                                                  checkBoxActiveToggle.Checked,
                                                  DateTime.Now,
                                                  App.currentUser,
                                                  DateTime.Now,
                                                  App.currentUser);
            customer.Address1 = inputAddress1.Text;
            customer.Phone = textBox7.Text;
            if (customer.Address2 == null) {
                customer.Address2 = "";

            }
            
            //add customer object to list of customers
            //App.AddCustomer(customer);
            //write data from customer object to database
            App.writeCustomerToDB(customer);
            App.AddCustomer(customer);
           // Customer.InitFromDB();
            this.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load_1(object sender, EventArgs e)
        {
            List<KeyValuePair<int, string>> countryData = App.GetAllCountries();
            var bs = new BindingSource(countryData, null);

            comboBox1.DataSource = bs;
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";


            List<KeyValuePair<int, string>> cityData = App.GetAllCities();
            var bs2 = new BindingSource(cityData, null);

            comboBoxCity.DataSource = bs2;
            comboBoxCity.DisplayMember = "Value";
            comboBoxCity.ValueMember = "Key";
        }
    }
}
