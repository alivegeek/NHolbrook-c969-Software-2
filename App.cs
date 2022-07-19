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

        public static bool isMod = false;

        public static bool apptIsMod = false;
        public static int GetNewCustomerID()
        {
            int ID = allCustomers.Count;
            return ID;

        }
        public static int GetCityID(Customer customer)
        {


            //make query
            string sql = "SELECT * FROM client_schedule.address";

            //DBConnector.ExecuteSQL(sql);

            MySqlDataReader DBResult = DBConnector.pollDB(sql);

            if (DBResult.HasRows)
            {
                //DBResult.Read();
                foreach (var x in DBResult)
                {
                    if (Convert.ToInt32(DBResult.GetValue(4)) == customer.AddressID)
                    {
                        return Convert.ToInt32(DBResult.GetValue(4));
                    }

                }

            }

            return 1;
        }

        //public static int GetAddressID(Customer customer)
        //{
        //    return 0;
        //}

        public static int GetCountryID(Customer customer)
        {
            String sql = "SELECT countryId, country FROM client_schedule.country";
            MySqlDataReader results = DBConnector.pollDB(sql);
            if (results.HasRows)
            {
                foreach (var row in results)
                {
                    try
                    {
                        String dbCountry = (string)results.GetValue(1);
                        String parmCountry = customer.Country;
                        if (String.IsNullOrEmpty(dbCountry) || String.IsNullOrEmpty(parmCountry)) { return 9999; } else {
                            parmCountry.ToUpper();
                            dbCountry.ToUpper();

                            if (dbCountry == parmCountry)
                            {
                                Debug.WriteLine(results.GetValue(0));
                                return Convert.ToInt32(results.GetValue(0));
                            }
                        } }
                    catch { }
                }
            }
            return 999999;
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
            MySqlDataReader results = DBConnector.pollDB(sql);
            if (results.HasRows)
            {
                foreach (var x in results)
                {
                    countryDict.Add(new KeyValuePair<int, string>(Convert.ToInt32(results[0]), Convert.ToString(results[1])));
                }
            }
            //                    MessageBox.Show("Login Successful");

            return countryDict;
        }


        public static List<KeyValuePair<int, string>> GetAllCustomers()
        {
            //List<string> listOfCities = new List<string>();
            List<KeyValuePair<int, string>> custDict = new List<KeyValuePair<int, string>>();
            String sql = "SELECT customerId, customerName FROM client_schedule.customer";
            MySqlDataReader results = DBConnector.pollDB(sql);
            if (results.HasRows)
            {
                foreach (var x in results)
                {
                    custDict.Add(new KeyValuePair<int, string>(Convert.ToInt32(results[0]), Convert.ToString(results[1])));
                }
            }
            //                    MessageBox.Show("Login Successful");

            return custDict;
        }

        public static List<string> GetAllTypes()
        {
            //List<string> listOfCities = new List<string>();
            List<string> typeDict = new List<string>();
            String sql = "SELECT type FROM client_schedule.appointment";
            MySqlDataReader results = DBConnector.pollDB(sql);
            if (results.HasRows)
            {
                foreach (var x in results)
                {
                    typeDict.Add(Convert.ToString(results[0]));
                }
            }
            //                    MessageBox.Show("Login Successful");

            return typeDict;
        }

        public static Appointments LookupAppointment(int apptId)
        {

            foreach (var appt in allAppts)
            {
                if (appt.AppointmentID == apptId) {

                    return appt;
                }

            }
            return null;

            ////make query
            //string sql = "SELECT * FROM client_schedule.appointment";

            ////DBConnector.ExecuteSQL(sql);
            //MySqlDataReader DBResult = DBConnector.pollDB(sql);
            //if (DBResult.HasRows)
            //{
            //    //DBResult.Read();
            //    foreach (var x in DBResult)
            //    {
            //        if (DBResult[0].ToString().Contains(appt.AddressID.ToString()))
            //        {
            //            return appt;
            //        }

            //    }

            //}
            //return null;
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

        public static string GetCustAddress(int customerID)
        {
            Customer customer = LookupCustomer(customerID);
            //make query
            string sql = "SELECT * FROM client_schedule.address";

            //DBConnector.ExecuteSQL(sql);
            MySqlDataReader DBResult = DBConnector.pollDB(sql);
            if (DBResult.HasRows)
            {
                //DBResult.Read();
                foreach (var x in DBResult)
                {
                    if (DBResult[0].ToString().Contains(customer.AddressID.ToString()))
                    {
                        Debug.WriteLine(DBResult[1].ToString());
                        return DBResult[1].ToString();
                    }

                }

            }
            return "";
        }

        public static string GetCustAddress2(int customerID)
        {
            Customer customer = LookupCustomer(customerID);
            String address = customer.Address2;
            //make query
            string sql = "SELECT * FROM client_schedule.address";

            //DBConnector.ExecuteSQL(sql);

            MySqlDataReader DBResult = DBConnector.pollDB(sql);

            if (DBResult.HasRows)
            {
                //DBResult.Read();
                foreach (var x in DBResult)
                {
                    if (DBResult[0].ToString().Contains(customer.AddressID.ToString()))
                    {
                        return DBResult[2].ToString();
                    }

                }

            }
            return "";
        }


        //public static string GetCustID(string name)
        //{
        //    Customer customer = LookupCustomer(customerID);
        //    //make query
        //    string sql = "SELECT * FROM client_schedule.address";

        //    //DBConnector.ExecuteSQL(sql);
        //    MySqlDataReader DBResult = DBConnector.pollDB(sql);
        //    if (DBResult.HasRows)
        //    {
        //        //DBResult.Read();
        //        foreach (var x in DBResult)
        //        {
        //            if (DBResult[0].ToString().Contains(customer.AddressID.ToString()))
        //            {
        //                Debug.WriteLine(DBResult[1].ToString());
        //                return DBResult[1].ToString();
        //            }

        //        }

        //    }
        //    return "";
        //}


        public static int AddAddress(Customer customer)
        {
            string address = customer.Address1.ToUpper();
            int addressID = customer.AddressID;
            string sql = "SELECT * FROM client_schedule.customer";
            MySqlDataReader DBResult = DBConnector.pollDB(sql);

            if (DBResult.HasRows)
            {
                //DBResult.Read();
                foreach (var x in DBResult)
                {
                    Debug.WriteLine(DBResult[0]);
                    if (DBResult[1].ToString().ToUpper().Contains(address) && DBResult[0].ToString().Equals(addressID))
                    {
                        return Convert.ToInt32(DBResult[0]);
                    }
                    else {
                        sql = $"INSERT INTO client_schedule.address ( address, address2, cityId, postalcode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) " +
                            $"VALUES (@address1, @address2, {customer.CityID}, @zip, @phone, @timeNow, @currentUser, @timeNow, @currentUser)";

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

                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch { }
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



        public static void delCustomerFromList(Customer customer)
        {
            allCustomers.Remove(customer);
        }

        public static Customer LookupCustomer(int customerID)
        {
            foreach (var obj in allCustomers)
            {
                if (obj.CustomerID == customerID)
                {
                    return obj;
                }
            }
            return null;
        }


        public static void delApptFromList(Appointments appt)
        {
            allAppts.Remove(appt);
        }

      
        public static int GetAddressID(string address)
        {
            address = address.ToUpper();
            //make query
            string sql = "SELECT * FROM client_schedule.address";

            //DBConnector.ExecuteSQL(sql);

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

            return 1;
            //toupper all the data

            //to upper the param

            //compare data

            //return address id or error
        }

        public static int GetUserID(string user)
        {
            //make query
            string sql = "SELECT userId, userName FROM client_schedule.user";

            //DBConnector.ExecuteSQL(sql);

            MySqlDataReader DBResult = DBConnector.pollDB(sql);

            if (DBResult.HasRows)
            {
                //DBResult.Read();
                foreach (var x in DBResult)
                {
                    if (DBResult[1].ToString().Contains(user))
                    {
                        return Convert.ToInt32(DBResult[0]);
                    }

                }

            }

            return 1;
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

            string sql = "INSERT INTO client_schedule.customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy ) " +
                $"VALUES (@CustomerName, @addressID , @active, @timeNow, @currentUser, @timeNow, @currentUser ) ";
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



        public static void writeApptToDB(Appointments appointment, bool tf)
        {


            var conn = DBConnector.NewSqlConnection();


            //string sql = "INSERT INTO client_schedule.appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy ) " +
            //    $"VALUES (@CustomerID, @UserID , @Title, @Description, @Location, @Contact, @Type, @Url, @Start, @End, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy ) ";
            //using (var cmd = new MySqlCommand(sql, conn))
            //{

            //    //get customer id 
            //    cmd.Parameters.Add("@CustomerID", MySqlDbType.VarChar).Value = appointment.CustomerId;

            //    cmd.Parameters.Add("@UserID", MySqlDbType.Int32).Value = GetUserID(App.currentUser);



            //    cmd.Parameters.Add("@Description", MySqlDbType.VarChar).Value = appointment.Description;

            //    cmd.Parameters.Add("@Location", MySqlDbType.VarChar).Value = appointment.Location;

            //    cmd.Parameters.Add("@Contact", MySqlDbType.VarChar).Value = appointment.Contact;

            //    cmd.Parameters.Add("@Type", MySqlDbType.VarChar).Value = appointment.Type;

            //    cmd.Parameters.Add("@Url", MySqlDbType.VarChar).Value = appointment.Url;

            //    cmd.Parameters.Add("@Start", MySqlDbType.DateTime).Value = appointment.StartTime;

            //    cmd.Parameters.Add("@End", MySqlDbType.DateTime).Value = appointment.EndTime;

            //    cmd.Parameters.Add("@Title", MySqlDbType.VarChar).Value = appointment.Title;


            //    cmd.Parameters.Add("@CreateDate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //    cmd.Parameters.Add("@CreatedBy", MySqlDbType.VarChar).Value = App.currentUser;

            //    cmd.Parameters.Add("@LastUpdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


            //    cmd.Parameters.Add("@LastUpdateBy", MySqlDbType.VarChar).Value = App.currentUser;
            //    ;
            if (tf == true) // true if we are modifying an existing record
            {
                string sql = "INSERT INTO client_schedule.appointment (customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy ) " +
                    $"VALUES (@CustomerID, @UserID , @Title, @Description, @Location, @Contact, @Type, @Url, @Start, @End, @CreateDate, @CreatedBy, @LastUpdate, @LastUpdateBy ) ";
                using (var cmd = new MySqlCommand(sql, conn))
                {

                    //get customer id 
                    cmd.Parameters.Add("@CustomerID", MySqlDbType.VarChar).Value = appointment.CustomerId;

                    cmd.Parameters.Add("@UserID", MySqlDbType.Int32).Value = GetUserID(App.currentUser);



                    cmd.Parameters.Add("@Description", MySqlDbType.VarChar).Value = appointment.Description;

                    cmd.Parameters.Add("@Location", MySqlDbType.VarChar).Value = appointment.Location;

                    cmd.Parameters.Add("@Contact", MySqlDbType.VarChar).Value = appointment.Contact;

                    cmd.Parameters.Add("@Type", MySqlDbType.VarChar).Value = appointment.Type;

                    cmd.Parameters.Add("@Url", MySqlDbType.VarChar).Value = appointment.Url;

                    cmd.Parameters.Add("@Start", MySqlDbType.DateTime).Value = appointment.StartTime;

                    cmd.Parameters.Add("@End", MySqlDbType.DateTime).Value = appointment.EndTime;

                    cmd.Parameters.Add("@Title", MySqlDbType.VarChar).Value = appointment.Title;


                    cmd.Parameters.Add("@CreateDate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    cmd.Parameters.Add("@CreatedBy", MySqlDbType.VarChar).Value = App.currentUser;

                    cmd.Parameters.Add("@LastUpdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                    cmd.Parameters.Add("@LastUpdateBy", MySqlDbType.VarChar).Value = App.currentUser;
                    ;
                    // Debug.WriteLine(cmd.ToString());

                    // cmd.Parameters.AddWithValue("@CustomerName");


                    cmd.ExecuteNonQuery();
                }
                //DBConnector.ExecuteSQL(sql);
                Console.WriteLine("Writing to DB");
                conn.Close();
            }
            else
            {
                string sql = "UPDATE client_schedule.appointment SET customerId = '@CustomerID', userId = '@UserID' , title='@Title', description='@Description', location='@Location', contact='@Contact', type='@Type', url='@Url', start='@Start', end='@End', createDate='@CreateDate', createdBy='@CreatedBy', lastUpdate='@LastUpdate', lastUpdateBy='@LastUpdateBy' WHERE customerID = @CustomerId ";
                using (var cmd = new MySqlCommand(sql, conn))
                {

                    //get customer id 
                    cmd.Parameters.Add("@CustomerID", MySqlDbType.VarChar).Value = appointment.CustomerId;

                    cmd.Parameters.Add("@UserID", MySqlDbType.Int32).Value = GetUserID(App.currentUser);



                    cmd.Parameters.Add("@Description", MySqlDbType.VarChar).Value = appointment.Description;

                    cmd.Parameters.Add("@Location", MySqlDbType.VarChar).Value = appointment.Location;

                    cmd.Parameters.Add("@Contact", MySqlDbType.VarChar).Value = appointment.Contact;

                    cmd.Parameters.Add("@Type", MySqlDbType.VarChar).Value = appointment.Type;

                    cmd.Parameters.Add("@Url", MySqlDbType.VarChar).Value = appointment.Url;

                    cmd.Parameters.Add("@Start", MySqlDbType.DateTime).Value = appointment.StartTime;

                    cmd.Parameters.Add("@End", MySqlDbType.DateTime).Value = appointment.EndTime;

                    cmd.Parameters.Add("@Title", MySqlDbType.VarChar).Value = appointment.Title;


                    cmd.Parameters.Add("@CreateDate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    cmd.Parameters.Add("@CreatedBy", MySqlDbType.VarChar).Value = App.currentUser;

                    cmd.Parameters.Add("@LastUpdate", MySqlDbType.VarChar).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                    cmd.Parameters.Add("@LastUpdateBy", MySqlDbType.VarChar).Value = App.currentUser;
                    ;
                    // Debug.WriteLine(cmd.ToString());

                    // cmd.Parameters.AddWithValue("@CustomerName");


                    cmd.ExecuteNonQuery();
                }
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
