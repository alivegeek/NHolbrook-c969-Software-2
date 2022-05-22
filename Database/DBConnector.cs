using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NHolbrook_c969_Software_2
{

    class DBConnector
    {
        static string connStr = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";

        public static MySqlConnection conn { get; set; }
        //public static SqlDataReader ExecuteSqlCommand {get; set;}

        public static void startConnection()
        {
           // string connStr = "server=localhost;user=sqlUser;database=client_schedule;port=3306;password=Passw0rd!";
            MySqlConnection conn = new MySqlConnection(connStr) ;
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open() ;
                Console.WriteLine("Opening DB connection. Is now " + conn.State);
//                string sql = "SELECT * FROM client_schedule.user";

             //   MySqlCommand cmd = new MySqlCommand(sql);
             //   MySqlDataReader rdr = cmd.ExecuteReader();

            }
            catch(Exception ex){ MessageBox.Show(ex.ToString()); }


        }
        public static MySqlDataReader pollDB(String sql)
        {
            MySqlConnection conn = new MySqlConnection(connStr)
            
                ;
                conn.Open();
                Debug.WriteLine(conn.State);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                MySqlDataReader requestedData = rdr;
                //rdr.Close();
                return requestedData;
            
        }
            public static void closeConnection()
        {
            return;
           // conn.Close();
        }

        // Function to execute select statements
    
    }
}
