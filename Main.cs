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
    }
}
