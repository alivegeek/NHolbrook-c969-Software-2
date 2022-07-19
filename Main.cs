using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NHolbrook_c969_Software_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();


        }



        private void buttonTest_Click(object sender, EventArgs e)
        {

        }

        public void Main_Load(object sender, EventArgs e)
        {
            //init Customer DGV

            customerDGV.AutoGenerateColumns = true;
            customerDGV.DataSource = App.allCustomers;

            customerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Customer.InitFromDB();

            //init appts DGV

            apptsDGV.AutoGenerateColumns = false;
            apptsDGV.DataSource = App.allAppts;

            apptsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            App.LoadAppointments();


        }

        private void buttonAddCust_Click(object sender, EventArgs e)
        {
            App.isMod = false;
            // create Addcustomer form and show
            AddCustomer ac = new AddCustomer();
            ac.Show();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDelCustomer_Click(object sender, EventArgs e)
        {
            Customer customerObjToDel = null;
            var conn = DBConnector.NewSqlConnection();
            try
            {
                DataGridViewRow selectedRow = customerDGV.SelectedRows[0];

                var customerID = Convert.ToInt32(selectedRow.Cells[0].Value);

                if (MessageBox.Show($"are you sure you want to delete {selectedRow.Cells[1].Value}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM client_schedule.customer WHERE customerId = @customerId;";


                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@customerId", MySqlDbType.Int32).Value = customerID;
                        cmd.ExecuteNonQuery();
                    }
                    //DBConnector.ExecuteSQL(sql);
                    conn.Close();

                    foreach(var x in App.allCustomers)
                    {
                        if (x.CustomerID == customerID)
                        {
                            customerObjToDel = x;
                           
                        }

                    }
                    App.delCustomerFromList(customerObjToDel);

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to delete.");
                return;
            }










        }

        private void buttonModCustomer_Click(object sender, EventArgs e)
        {
            App.isMod = true;
            //Create form object
            AddCustomer ac = new AddCustomer();

            // get ID from DGV
            DataGridViewRow selectedRow = customerDGV.SelectedRows[0];

            var customerID = Convert.ToInt32(selectedRow.Cells[0].Value);
            // Lookup Customer 
            Customer cust = App.LookupCustomer(customerID);
            if (cust.CustomerID == null){
                MessageBox.Show("Error: Customer not found");
                return;
            }

            List<KeyValuePair<int, string>> cityData = App.GetAllCities();
            var bs2 = new BindingSource(cityData, null);

            ac.comboBoxCity.DataSource = bs2;
            ac.comboBoxCity.DisplayMember = "Value";
            ac.comboBoxCity.ValueMember = "Key";



            //Populate Form from customer object
            ac.inputCustomerID.Text = cust.CustomerID.ToString(); ;
            ac.inputName.Text = cust.CustomerName;
            ac.inputAddress1.Text = cust.Address1;
            ac.inputAddress2.Text = cust.Address2;
            ac.inputZip.Text = cust.Zip.ToString() ;
            ac.textBox7.Text = cust.Phone;
            ac.comboBoxCity.SelectedIndex = App.GetCityID(cust);
            //int index = 2;
            try
            {
                ac.comboBox1.SelectedIndex = App.GetCountryID(cust);
            }
            catch (Exception) { ac.comboBox1.SelectedIndex = -1; }


            // show form
            ac.Show();
            // Set ID to be uneditable 

            // SQL Update Statement

        }

        private void addAppointmentsButton_Click(object sender, EventArgs e)
        {
            AddAppointment appt = new AddAppointment();
            App.apptIsMod = false;
            appt.Show();
        }

        private void buttonModifyAppts_Click(object sender, EventArgs e)
        {
            App.apptIsMod = true;
            //Create form object
            //Appointments ap = new Appointments();
            AddAppointment aa = new AddAppointment();
            // get ID from DGV
            DataGridViewRow selectedRow = apptsDGV.SelectedRows[0];

            var apptId = Convert.ToInt32(selectedRow.Cells[0].Value);
            // Lookup Customer 
            Appointments appt = App.LookupAppointment(apptId);
            if (appt.AppointmentID == null)
            {
                MessageBox.Show("Error: Customer not found");
                return;
            }
            List<KeyValuePair<int, string>> customerData = App.GetAllCustomers();
            List<string> typeData = App.GetAllTypes();
            var bs2 = new BindingSource(typeData, null);
            var bs = new BindingSource(customerData, null);
            aa.comboBoxCustomer.DataSource = bs;
            aa.comboBoxCustomer.DisplayMember = "Value";
            aa.comboBoxCustomer.ValueMember = "Key";
      
   
            aa.comboBoxType.DataSource = bs2;
            //comboBoxType.DisplayMember = "Value";
            //comboBoxType.ValueMember = "Key";
            bs2.Add("Type1");
            bs2.Add("Type2");
            bs2.Add("Type3");


            //Populate Form from appt object
            aa.inputTitle.Text = appt.Title;
            aa.inputDesc.Text = appt.Description;
            aa.inputLocation.Text = appt.Location;
            aa.inputContact.Text = appt.Contact;
       //     aa.dateTimePickerStart.Value = ap.StartTime;
       //     aa.dateTimePickerEnd.Value = ap.EndTime;
            aa.labelApptId.Text = appt.AppointmentID.ToString();



            // show form
            aa.Show();
            // Set ID to be uneditable 

            // SQL Update Statement
        }

        private void buttonDeleteAppts_Click(object sender, EventArgs e)
        {
            Appointments apptToDel = null;
            var conn = DBConnector.NewSqlConnection();
            try
            {
                DataGridViewRow selectedRow = apptsDGV.SelectedRows[0];

                var apptID = Convert.ToInt32(selectedRow.Cells[0].Value);

                if (MessageBox.Show($"are you sure you want to delete appointment{selectedRow.Cells[0].Value} with title {selectedRow.Cells[3].Value}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM client_schedule.appointment WHERE appointmentId = @appointmentId;";


                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = apptID;
                        cmd.ExecuteNonQuery();
                    }
                    //DBConnector.ExecuteSQL(sql);
                    conn.Close();

                    foreach (var x in App.allAppts)
                    {
                        if (x.AppointmentID == apptID)
                        {
                            apptToDel = x;

                        }

                    }
                    App.delApptFromList(apptToDel);

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select something to delete.");
                return;
            }


        }
    }    
}
    

