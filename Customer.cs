using System;
using MySql.Data.MySqlClient;
using System.Diagnostics;
namespace NHolbrook_c969_Software_2
{
    public class Customer
    {
        int AppointmentID { get; set; }
        public int CustomerID { get; set; }


        public String CustomerName { get; set; }
        public int AddressID { get; set; }

        public Boolean Active { get; set; }
        DateTime CreateDate { get; set; }
        String CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        String LastUpdatedBy { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public int Zip { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public int CityID { get; set; }


        //contructor/s
        public Customer(int customerID, string customerName, int addressID, bool active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy){

            CustomerID = customerID;
            CustomerName = customerName;
            AddressID = addressID;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;


        }
        public Customer(string customerName, string address1, string address2, string city, int zipcode, string country, bool active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {

            CustomerName = customerName;
            Address1 = address1;
            Address2 = address2;
            City = city;
            Zip = Zip;
            Country = country;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;


        }
        public Customer(string customerName, int addressID, bool active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
        {

            CustomerName = customerName;
            AddressID = addressID;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;


        }
        public Customer()
        {

        }
        //populate from db
        public static void InitFromDB()
        {


            //set SQL query to be passed to DB
            //String sql = "SELECT customerId, customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy FROM client_schedule.customer;";
            String sql = "SELECT * FROM client_schedule.customer;";

            //Execute DB query
            MySqlDataReader DBResult = DBConnector.pollDB(sql);

            //debugging - how many rows did the DM return?
            int RowCount = 0;
            Debug.WriteLine("Counting Rows returned from Database");
            //while (DBResult.Read())
            //{
            //    RowCount++;
            //    Debug.WriteLine(RowCount);
            //}
            Debug.WriteLine("End counting rows \n");
            // for each row call the constructor above to create a custoemr object
            //test



            while (DBResult.Read())
            {
                Debug.WriteLine("printing customers names to debug console");
                Debug.WriteLine(DBResult[1].ToString());
                Debug.WriteLine("customer ID # " + DBResult[0].ToString());//custID

                //read data and populate Class vars 
                int customerID = Convert.ToInt32(DBResult[0]);
                string customerName = DBResult[1].ToString();
                int addressID = Convert.ToInt32(DBResult[2]);
                bool active = Convert.ToBoolean(DBResult[3]);
                DateTime createDate = Convert.ToDateTime(DBResult[4]);
                string createdBy = DBResult[5].ToString();
                DateTime lastUpdate = Convert.ToDateTime(DBResult[6]);
                string lastUpdatedBy = DBResult[7].ToString();
                Customer customer = new Customer(customerID, customerName, addressID, active, createDate,createdBy,lastUpdate,lastUpdatedBy);
                //Customer customer = new Customer();
                // Add new customer object to the list of customers for DGV
                App.AddCustomer(customer);
                DBConnector.closeConnection();

            }


            // if (DBResult.HasRows)
            //{
            //foreach (MySqlDataReader x in DBResult)
            //    {

            //        //do stuff
            //        // debugging - is anything coming in null? 
            //        //if(DBResult[1] is null){
            //        //    Debug.WriteLine("This line is null");
            //        //}
            //        //print the customer name to debug console
            //        Debug.WriteLine("printing customers names to debug console");
            //        Debug.WriteLine(DBResult[1].ToString());
            //        Debug.WriteLine(DBResult[0].ToString());//custID

            //        //read data and populate Class vars 
            //        int customerID = Convert.ToInt32(DBResult[0]);
            //        string customerName = DBResult[1].ToString();
            //        int addressID = Convert.ToInt32(DBResult[2]);
            //        bool active = Convert.ToBoolean(DBResult[3]);
            //        DateTime createDate = Convert.ToDateTime(DBResult[4]);
            //        string createdBy = DBResult[5].ToString();
            //        DateTime lastUpdate = Convert.ToDateTime(DBResult[6]);
            //        string lastUpdatedBy = DBResult[7].ToString();
            //        //  Customer customer = new Customer(customerID, customerName, addressID, active, createDate,createdBy,lastUpdate,lastUpdatedBy);
            //        Customer customer = new Customer();
            //        // Add new customer object to the list of customers for DGV
            //        App.AddCustomer(customer);
            //    }

            //}

            // Debug.WriteLine("TESTING CUSTOMER CLASS " + DBResult[0].ToString()); //future me, for loop to print it all DBResult[0].ToString // Nevermind future me jsut do Title = DBResult[4] etc

        }




        
    }
}
