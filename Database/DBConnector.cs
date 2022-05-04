using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHolbrook_c969_Software_2
{
    class DBConnector
    {
        public static SqlConnection conn { get; set; }

        public static void startConnection()
        {
            try {
                string conStr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);    
            }
            finally
            {
                if (conn != null)

                    conn.Close();
                conn = null;
            }

        }

        public static void closeConnection()
        {

        }
    }
}
