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

            this.Close();
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // create a customer object
            // int custID = App.GetNewCustomerID();



            if (App.isMod == false)
            {


                Customer customer = new Customer(
                                                      inputName.Text,
                                                      comboBox1.SelectedIndex, //future me make this a required field
                                                      checkBoxActiveToggle.Checked,
                                                      DateTime.Now,
                                                      App.currentUser,
                                                      DateTime.Now,
                                                      App.currentUser);
                customer.CityID = comboBoxCity.SelectedIndex;
                customer.Address1 = inputAddress1.Text;
                customer.Phone = textBox7.Text;
                if (customer.Address2 == null)
                {
                    customer.Address2 = "";

                }

                //add customer object to list of customers
                //App.AddCustomer(customer);
                //write data from customer object to database
                App.writeCustomerToDB(customer);
                App.AddCustomer(customer);
                // Customer.InitFromDB();
            }
            else
            {
                Customer customer = App.LookupCustomer(Convert.ToInt32(inputCustomerID.Text));
                customer.CustomerName = inputName.Text;
                customer.Address1 = inputAddress1.Text;
                customer.Address2 = inputAddress2.Text;
                customer.CityID = comboBoxCity.SelectedIndex;
                customer.Zip = Convert.ToInt32(inputZip.Text);
                customer.Phone = textBox7.Text;
                customer.Active = checkBoxActiveToggle.Checked;
                //customer.Country = 
            }
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

            buttonSave.Enabled = false;
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
                {
                    e.Handled = true;
                }
                else
                {
                    // is a digit or backspace - ignore digits if length is alreay 10 - allow backspace
                    if (Char.IsDigit(e.KeyChar))
                    {
                        if (textBox7.Text.Length > 9)
                        {
                            e.Handled = true;
                        buttonSave.Enabled = true;
                        textBox7.BackColor = Color.White;
                    }
                    }
                }
            
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if ((textBox7.Text.Length < 10) && (textBox7.Text.Length > 0))
            {
                MessageBox.Show("Phone number must be 10 digits!");
                textBox7.Focus();
            }else
            {
                buttonSave.Enabled = true;
                textBox7.BackColor = Color.White;
            }
        }

        private void inputZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                // is a digit or backspace - ignore digits if length is alreay 10 - allow backspace
                if (Char.IsDigit(e.KeyChar))
                {
                    if (textBox7.Text.Length > 9)
                    {
                        e.Handled = true;
                        buttonSave.Enabled = true;
                    }
                }
            }
        }

        private void inputZip_Leave(object sender, EventArgs e)
        {
            if ((inputZip.Text.Length < 5) && (inputZip.Text.Length > 0))
            {
                MessageBox.Show("Postal code must be 5 digits!");
                inputZip.Focus();
            }else
            {
                inputZip.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }

        private void inputName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputName.Text))
            {
                //e.Cancel = true;
 //               inputName.Focus();
                inputName.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
             //   e.Cancel = false;
                inputName.BackColor = Color.White;
                buttonSave.Enabled = true;
                
            }
        }

        private void inputAddress1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputAddress1.Text))
            {
              //  e.Cancel = true;
             //   inputName.Focus();
                inputAddress1.BackColor = Color.Red;
                buttonSave.Enabled = false;

            }
            else
            {
               // e.Cancel = false;
                inputAddress1.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }

        private void comboBoxCity_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void inputZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void buttonSave_MouseHover(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputName.Text))
            {
              //  inputName.Focus();
                inputName.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
                inputName.BackColor = Color.White;
                buttonSave.Enabled = true;

            }

            if (string.IsNullOrWhiteSpace(inputAddress1.Text))
            {
              //  inputAddress1.Focus();
                inputAddress1.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
                inputAddress1.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
            if (string.IsNullOrWhiteSpace(inputZip.Text))
            {
               // inputZip.Focus();
                inputZip.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
                inputZip.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
            if (string.IsNullOrWhiteSpace(textBox7.Text)) //phone
            {
               // textBox7.Focus();
                textBox7.BackColor = Color.Red;
                buttonSave.Enabled = false;
            }
            else
            {
                textBox7.BackColor = Color.White;
                buttonSave.Enabled = true;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
