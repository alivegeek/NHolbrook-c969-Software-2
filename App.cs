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
using System.Diagnostics;

namespace NHolbrook_c969_Software_2

{
    public class App
    {


        public static BindingList<Customer> allCustomers = new BindingList<Customer>();
      //  public BindingSource source = new BindingSource(allCustomers, null);
        public static BindingList<Appointments> allAppts = new BindingList<Appointments>();
        public static string currentUser;
        //determine next customer id
        public static int GetNewCustomerID()
        {
            int ID = allCustomers.Count;
            return ID;

        }
        public static int GetCityID(Customer customer)
        {
            return 0;
        }

        //public static int GetAddressID(Customer customer)
        //{
        //    return 0;
        //}

        public static int GetCountryID(Customer customer)
        {
            return 0;
        }

        public static void RemoveAllCustList()
        {

            App.allCustomers = new BindingList<Customer>();
           int customers = allCustomers.Count();
        //    int x = 0;
            Debug.WriteLine("We have " + customers + "customers");
        //    //If list is populated empty it
        //    while ( x <= customers) {


        //        Debug.WriteLine("Removing vustomer " + x);

        //            allCustomers.RemoveAt(allCustomers.Count());
        //            x++;




                
                
            
        }

            
            
            
        
       
        public static List<KeyValuePair<int, string>> GetAllCountries()
        {
            //List<string> listOfCities = new List<string>();
            List<KeyValuePair<int, string>> countryDict = new List<KeyValuePair<int, string>>();
            String sql = "SELECT countryId, country FROM client_schedule.country";
            MySqlDataReader results =  DBConnector.pollDB(sql);
            if (results.HasRows)
            {
                foreach(var x in results)
                {
                    countryDict.Add(new KeyValuePair<int, string>( Convert.ToInt32(results[0]), Convert.ToString(results[1])));
                }
            }
                //                    MessageBox.Show("Login Successful");
                
            return countryDict;
        }

        public static List<KeyValuePair<int, string>> GetAllCities()
        {
            //List<string> listOfCities = new List<string>();
            List<KeyValuePair<int, string>> cityDict = new List<KeyValuePair<int, string>>();
            String sql = "SELECT cityId, city FROM client_schedule.city";
            MySqlDataReader results = DBConnector.pollDB(sql);
            if (results.HasRows)
            {
                foreach (var x in results)
                {
                    cityDict.Add(new KeyValuePair<int, string>(Convert.ToInt32(results[0]), Convert.ToString(results[1])));
                }
            }
            //                    MessageBox.Show("Login Successful");

            return cityDict;
        }

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
            //BResult.Read();

            // for each row call the constructor above to create a custoemr object
            if (DBResult.HasRows)
            {
                //DBResult.Read();
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

        public static int AddAddress(Customer customer)
        {
            string address = customer.Address1.ToUpper();
            
            string sql = "SELECT * FROM client_schedule.customer";
            MySqlDataReader DBResult = DBConnector.pollDB(sql);

            if (DBResult.HasRows)
            {
                //DBResult.Read();
                foreach (var x in DBResult)
                {
                    if (DBResult[1].ToString().ToUpper().Contains(address))
                    {
                        return Convert.ToInt32(DBResult[0]);
                    }
                    else { 
                        sql = "INSERT INTO client_schedule.address ( address, address2, cityId, postalcode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            $"VALUES (@address1, @address2, 1, @zip, @phone, @timeNow, @currentUser, @timeNow, @currentUser)";
                        var conn = DBConnector.NewSqlConnection();

                       
                        using (var cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.Add("@address1", MySqlDbType.VarChar).Value = customer.Address1;
                            cmd.Parameters.Add("@address2", MySqlDbType.VarChar).Value = customer.Address2;
                            cmd.Parameters.Add("@zip", MySqlDbType.Int32).Value = Convert.ToInt32(customer.Zip);
                            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = customer.Phone;
                            cmd.Parameters.Add("@timeNow", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            cmd.Parameters.Add("@currentUser", MySqlDbType.VarChar).Value = App.currentUser;

                            ;


                            // Debug.WriteLine(cmd.ToString());

                            // cmd.Parameters.AddWithValue("@CustomerName");


                            cmd.ExecuteNonQuery();
                        }
                        //DBConnector.ExecuteSQL(sql);
                        Console.WriteLine("Writing to DB");
                        conn.Close();

                        return GetAddressID(DBResult[1].ToString()); //need to write this
                    }
                    
                }
            }
            return 9999;
        }

        public static int GetAddressID(string address)
        {
            address = address.ToUpper();
            //make query
            string sql = "SELECT * FROM client_schedule.address";

            MySqlDataReader DBResult = DBConnector.pollDB(sql);

            if (DBResult.HasRows)
            {
                //DBResult.Read();
                foreach (var x in DBResult)
                {
                    if (DBResult[1].ToString().ToUpper().Contains(address))
                    {
                        return Convert.ToInt32(DBResult[0]);
                    }
                   
                }

            }

            return 1 ;
            //toupper all the data

            //to upper the param

            //compare data

            //return address id or error
        }
        public static void writeCustomerToDB(Customer customer)
        {
            
            Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));	
	



           // String sql = $"INSERT INTO client_schedule.customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy ) VALUES ({customer.CustomerName}, {customer.Address1}, {Convert.ToInt32(customer.Active)}, {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}, {currentUser}, {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}, {currentUser} ); "; //note to self, come back and do this in UTC or that weird computer time so that we can adjust for timezones.
                                                                                                                                                                                                                                                                                      //Console.WriteLine(sql);
                                                                                                                                                                                                                                                                                      //  BaseCommandInterceptor.Parameters.Add
            var conn = DBConnector.NewSqlConnection();
                                                                                                                                                                                                                                                                     //https://stackoverflow.com/questions/26669400/insert-quote-in-mysql-using-c-sharp
                                                                                                                                                                                                                                                                                      //    $"INSERT INTO client_schedule.address (address, address2, cityID, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES  ({customer.Address1}, {customer.Address2}, 99, {customer.Zip}, 5555555555, {DateTime.Now}, {App.currentUser},  {DateTime.Now}, {App.currentUser} )"; 
            //MySqlCommand cmd = new MySqlCommand($"INSERT INTO client_schedule.customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy ) " +
            //    $"VALUES (@CustomerName, @addressID , @active, {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}, @currentUser, {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}, @currentUser ); " , conn);
            ////conn.Open();

            int aID = GetAddressID(customer.Address1);

            string sql ="INSERT INTO client_schedule.customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy ) " +
                $"VALUES (@CustomerName, @addressID , @active, @timeNow, @currentUser, @timeNow, @currentUser ) " ;
            using (var cmd = new MySqlCommand(sql, conn)) {
                cmd.Parameters.Add("@CustomerName", MySqlDbType.VarChar).Value = customer.CustomerName;
                //cmd.Parameters.Add("@addressID", MySqlDbType.Int16).Value = GetAddressID(customer.Address1.ToString());
                cmd.Parameters.Add("@addressID", MySqlDbType.Int16).Value = AddAddress(customer);
                cmd.Parameters.Add("@active", MySqlDbType.Int16).Value = Convert.ToInt32(customer.Active);
                cmd.Parameters.Add("@currentUser", MySqlDbType.VarChar).Value = App.currentUser;
                cmd.Parameters.Add("@timeNow", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
;


                // Debug.WriteLine(cmd.ToString());

                // cmd.Parameters.AddWithValue("@CustomerName");


                cmd.ExecuteNonQuery();
            }
            //DBConnector.ExecuteSQL(sql);
            Console.WriteLine("Writing to DB");
            conn.Close();
        }

        //Sync all data with DB
        public static void SyncWithDB()
        {
            return;
        }
    }
    //test SQL - remove later
}//INSERT INTO client_schedule.customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy ) 
//VALUES("Bob DOle", 1, 1, "2019-01-01 00:00:00", "dad", "2019-01-01 00:00:00", "dad");
