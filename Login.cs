using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHolbrook_c969_Software_2;
using System.Diagnostics;
using System.Data.SqlClient;
namespace NHolbrook_c969_Software_2

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM client_schedule.user";
            DBConnector.pollDB(sql);
            //this might be a place to use a lambda
            

           

        }
    }
}