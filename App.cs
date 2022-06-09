using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NHolbrook_c969_Software_2;
using System.Data.SqlClient;
namespace NHolbrook_c969_Software_2
{
    public class App
    {


        public static BindingList<Customer> allCustomers = new BindingList<Customer>();
      //  public BindingSource source = new BindingSource(allCustomers, null);
        public static BindingList<Appointments> allAppts = new BindingList<Appointments>();



        public static void AddCustomer(Customer customer)
        {
            allCustomers.Add(customer);
            
        }

        public static void AddAppointment(Appointments appt)
        {
            allAppts.Add(appt);
        }
        public static void LoadAppointments()
        {
            //set SQL query to be passed to DB
            String sql = "SELECT * FROM client_schedule.appointment;"; // toDo replace * with specifics

            //Execute DB query
            MySqlDataReader DBResult = DBConnector.pollDB(sql);
            DBResult.Read();

            // for each row call the constructor above to create a custoemr object
            if (DBResult.HasRows)
            {
            //    DBResult.Read();
                foreach (var x in DBResult)
                {
                    //new customer object
                    Appointments appt = new Appointments();
                    //read data and populate Class vars 
                    appt.AppointmentID = Convert.ToInt32(DBResult[0]);
                    appt.CustomerId = Convert.ToInt32(DBResult[1]);
                    appt.UserId = Convert.ToInt32(DBResult[1]);
                    appt.Title = DBResult[3].ToString();
                    appt.Description = DBResult[4].ToString();
                    appt.Location = DBResult[5].ToString();
                    appt.Contact = DBResult[6].ToString();
                    appt.Type = DBResult[7].ToString();
                    appt.Url = DBResult[8].ToString();
                    appt.StartTime = Convert.ToDateTime(DBResult[9]);
                    appt.EndTime = Convert.ToDateTime(DBResult[10]);
                    appt.CreateDate = Convert.ToDateTime(DBResult[11]);
                    appt.CreatedBy = DBResult[12].ToString();
                    appt.LastUpdate = Convert.ToDateTime(DBResult[13]);
                    appt.LastUpdatedBy = DBResult[14].ToString();

                    // Add new customer object to the list of customers for DGV
                    App.AddAppointment(appt);
                    
                }


            }
        }
    }

}
