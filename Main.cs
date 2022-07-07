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
    }    
}
    

