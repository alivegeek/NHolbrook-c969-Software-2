using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NHolbrook_c969_Software_2
{
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.ShowUpDown = true;
           // dateTimePickerStart.CustomFormat = "MMMM dd, yyyy - dddd";
          
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "MM'-'dd'-'yyyy hh':'mm:tt";
            dateTimePickerStart.ShowUpDown = true;
            // _ = ((long)dateTimePickerStart.Format);

            // dateTimePickerEnd.ShowUpDown = true;
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "MM'-'dd'-'yyyy hh':'mm:tt";
            dateTimePickerEnd.ShowUpDown = true;
            //_ = ((long)dateTimePickerEnd.Format);

            List<KeyValuePair<int, string>> customerData = App.GetAllCustomers();
            var bs = new BindingSource(customerData, null);

            comboBoxCustomer.DataSource = bs;
            comboBoxCustomer.DisplayMember = "Value";
            comboBoxCustomer.ValueMember = "Key";

            List<string> typeData = App.GetAllTypes();
            var bs2 = new BindingSource(typeData, null);

            comboBoxType.DataSource = bs2;
            //comboBoxType.DisplayMember = "Value";
            //comboBoxType.ValueMember = "Key";
            bs2.Add("Type1");
            bs2.Add("Type2");
            bs2.Add("Type3");

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            dateTimePickerStart.ShowUpDown = true;
            // dateTimePickerStart.CustomFormat = "MMMM dd, yyyy - dddd";

            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "MM'-'dd'-'yyyy hh':'mm:tt";
            dateTimePickerStart.ShowUpDown = true;
            // _ = ((long)dateTimePickerStart.Format);

            // dateTimePickerEnd.ShowUpDown = true;
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "MM'-'dd'-'yyyy hh':'mm:tt";
            dateTimePickerEnd.ShowUpDown = true;
            //_ = ((long)dateTimePickerEnd.Format);

            List<KeyValuePair<int, string>> customerData = App.GetAllCustomers();
            var bs = new BindingSource(customerData, null);

            comboBoxCustomer.DataSource = bs;
            comboBoxCustomer.DisplayMember = "Value";
            comboBoxCustomer.ValueMember = "Key";

            List<string> typeData = App.GetAllTypes();
            var bs2 = new BindingSource(typeData, null);

            comboBoxType.DataSource = bs2;


            if (App.apptIsMod == false)
            {


                Appointments appointment = new Appointments(
                                                      Convert.ToInt32(comboBoxCustomer.SelectedValue), //future me make this a required field
                                                      App.GetUserID(App.currentUser),
                                                      inputTitle.Text,
                                                      inputDesc.Text,
                                                      inputLocation.Text,
                                                      inputContact.Text,
                                                      comboBoxType.Text,
                                                      inputURL.Text,
                                                      dateTimePickerStart.Value,
                                                      dateTimePickerEnd.Value
                                                      );


                //add customer object to list of customers
                //App.AddCustomer(customer);
                //write data from customer object to database
                Debug.WriteLine(inputDesc.Text);
                App.writeApptToDB(appointment, true);
                App.AddAppointment(appointment);
                this.Close();
                // Customer.InitFromDB();
            }
            else
            {
                Appointments appt = App.LookupAppointment(Convert.ToInt32(labelApptId.Text));

                appt.CustomerId = 3;

                //appt.CustomerId = Convert.ToInt32(comboBoxCustomer.SelectedValue);
                Debug.WriteLine("Slected cust ID is " + Convert.ToInt32(comboBoxCustomer.SelectedValue));
                appt.Title = inputTitle.Text;
                appt.Description = inputDesc.Text;
                appt.Location = inputLocation.Text;
                appt.Contact = inputContact.Text;
                appt.Type = comboBoxType.Text;
                appt.Url = inputURL.Text;
                appt.StartTime = dateTimePickerStart.Value;
                appt.EndTime = dateTimePickerEnd.Value;
                appt.UserId = App.GetUserID(App.currentUser);


                //add customer object to list of customers
                //App.AddCustomer(customer);
                //write data from customer object to database
                //Debug.WriteLine(inputDesc.Text);
                App.writeApptToDB(appt, true);
                //{
                //    Customer customer = App.LookupCustomer(Convert.ToInt32(inputCustomerID.Text));
                //    customer.CustomerName = inputName.Text;
                //    customer.Address1 = inputAddress1.Text;
                //    customer.Address2 = inputAddress2.Text;
                //    customer.CityID = comboBoxCity.SelectedIndex;
                //    customer.Zip = Convert.ToInt32(inputZip.Text);
                //    customer.Phone = textBox7.Text;
                //    customer.Active = checkBoxActiveToggle.Checked;
                //    //customer.Country = 
                //}
                
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

