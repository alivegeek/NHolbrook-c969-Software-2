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
using System.Globalization;
namespace NHolbrook_c969_Software_2

{
    public partial class Login : Form
    {
        private string alertUserName;

        public Login()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';

            //get locals from OS
           int locale = CultureInfo.CurrentUICulture.LCID; //returns a locale identifier LCID 1033 is En US 21514 is Spanish US

            String alertUserName = "User Name Not Found.";
            String alertPassword = "Incorrect Password";
            if (locale == 21514)
            {
                titleLabel.Text = "Autenticación";
                userNameLabel.Text = "Usuario";
                passwordLabel.Text = "Contraseña";
                alertUserName = "Nombre de usuario no encontrado";
                alertPassword = "Contraseña incorrecta";
            }
            

        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
           

            //this might be a place to use a lambda
            String submittedUsername = usernameTextBox.Text;
            String submittedPassword = passwordTextBox.Text;
            MySqlDataReader DBResult = null;
            String sql = $"SELECT * FROM client_schedule.user WHERE userName ='{submittedUsername}'; "; //This should be treated as a literal for security e.g use an @
            Debug.WriteLine(sql);
            DBResult = DBConnector.pollDB(sql);
            Debug.WriteLine(DBResult.HasRows);
            if (DBResult.HasRows) 
            {

                //check password 
                sql = $"SELECT userName, password FROM client_schedule.user WHERE userName='{submittedUsername}' AND password ='{submittedPassword}'; ";
                DBResult = DBConnector.pollDB(sql);
                if (DBResult.HasRows)
                {
//                    MessageBox.Show("Login Successful");
                    Main main = new Main();
                    main.Show();
                  //  this.Close();
                   
                    
                } else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
               // Debug.WriteLine(DBResult.GetValue();

                MessageBox.Show(alertUserName);

            }
            //nested if else to check that username exists and if password is correct





        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}