using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace EMS_2
{
    class DataAccess
    {
        private SqlConnection con;          // connection object
        private SqlCommand cmd;             // command object

        // constructor
        public DataAccess()
        {
            string constring = ConfigurationManager.ConnectionStrings["DB_ConnectionString"].ConnectionString;

            // establish connection
            InitilizeConnection(constring);
        }

        /***********************************************************************************|
        |    Name:           InitilizeConnection()                                          |
        |    Parameters:     string con_string - connection string                          |
        |    Returns:        true - if success, false otherwise                             |
        |    Purpose:        The purpose of this method is to establish the connection      |
        |                    with the database, and if successfully establish, return       |
        |                    true to calling method.                                        |
        *************************************************************************************/
        public bool InitilizeConnection(string con_string)
        {
            // pass the connection string to connection object
            try
            {
                con = new SqlConnection(con_string);
                cmd = new SqlCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in database connection string.\n\n" + ex, "Connection String Error");
                return false;
            }

            // open the connection
            try
            {
                con.Open();
                cmd.Connection = con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in opening source connection.\n\n" + ex, "Connection Open");
                con.Close();
                return false;       // return false upon failure
            }

            // display message if successful
            MessageBox.Show("Connection successfully established... :)", "Connection Success");
            return true;
        }


        /*********************************************************************************|
        |    Name:           GetData()                                                    |
        |    Parameters:     string query - sql query to be executed                      |
        |    Returns:        SqlDataReader - the result in form of data reader            |
        |    Purpose:        The purpose of this method is to execute the query           |
        |                    passed as parameter and return the SqlDataReader object.     |
        **********************************************************************************/
        public SqlDataReader GetData(string query)
        {
            SqlDataReader reader;
            cmd.CommandText = query;

            // execute reader
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while executing reader.\n\n" + ex, "Reader Error");
                return null;
            }

            return reader;
        }


        /************************************************************************************|
        |    Name:           CloseConnection()                                               |
        |    Parameters:     void                                                            |
        |    Returns:        true if successfully closed, false otherwise.                   |
        |    Purpose:        The purpose of this method is to close the connection           |
        |                    with the database.                                              |
        *************************************************************************************/
        public bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
