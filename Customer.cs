using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHolbrook_c969_Software_2;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Diagnostics;
namespace NHolbrook_c969_Software_2
{
   public class Customer
    {
        int AppointmentID { get; set; }
        int CustomerID { get; set; }
        int UserID { get; set; }
        String Title { get; set; }
        String Description { get; set; }
        String Location { get; set; }
        String Contact { get; set; }
        String type { get; set; }
        String URL { get; set; }
        DateTime Start { get; set; }
        DateTime End { get; set; }
        DateTime CreateDate { get; set; }
        String CreatedBy { get; set; }
        DateTime LastUpdate { get; set; }
        String LastUpdatedBy { get; set; }


        //contructor
        public Customer(int customerID, int userID, string title, string description, string location, string contact, string type2, string url, DateTime start, DateTime end, DateTime createDate, String createdBy, DateTime lastUpdate, String lastUpdatedBy) 
        {
            CustomerID = customerID;
            UserID = userID;
            Title = title;
            Description = description;
            Location = Location;
            Contact = Contact;
            type = type2;
            URL = url;
            Start = start;
            End = end;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;


        }
        //contruction populated from DB
        public Customer()
        {

            //set SQL query to be passed to DB
            String sql = "SELECT * FROM client_schedule.customer;";

            //Execute DB query
            MySqlDataReader DBResult = DBConnector.pollDB(sql);

            // for each row call the constructor above to create a custoemr object
            if (DBResult.HasRows)
            {
                //do stuff
                DBResult.Read();
                Debug.WriteLine("TESTING CUSTOMER CLASS CONSTRUX" + DBResult[1].ToString()); //future me, for loop to print it all DBResult[0].ToString // Nevermind future me jsut do Title = DBResult[4] etc

            }

               
             
            //        //read data and populate Class vars 
            //        CustomerID = customerID;
            //UserID = userID;
            //Title = title;
            //Description = description;
            //Location = Location;
            //Contact = Contact;
            //type = type2;
            //URL = url;
            //Start = start;
            //End = end;
            //CreateDate = createDate;
            //CreatedBy = createdBy;
            //LastUpdate = lastUpdate;
            //LastUpdatedBy = lastUpdatedBy;
        }
    }
}
