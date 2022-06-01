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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
           
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //customerDGV.AutoGenerateColumns = true;
 //init Customer DGV

            customerDGV.AutoGenerateColumns = true;
            customerDGV.DataSource = App.allCustomers;

            customerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDGV.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            customerDGV.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            Customer.InitFromDB();
            //init appts DGV
            apptsDGV.AutoGenerateColumns = true;
            apptsDGV.DataSource = App.allAppts;

            apptsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            apptsDGV.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            apptsDGV.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            App.LoadAppointments();

            //foreach (var x in App.allCustomers)
            //{
            //    Debug.WriteLine(x.ToString());
            //}

        }

        private void customerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
