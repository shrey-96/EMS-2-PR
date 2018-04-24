using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

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

        public string GetColumnData(string query, string column)
        {
            string result = "";

            using (SqlDataReader reader = GetData(query))
            {
                while (reader.Read())
                {
                    result = reader[column].ToString();
                }
            }

            return result;
        }

        public void Add_Update_Patient(bool insert, string hcn, string lastname, string firstname, string minitial, string dob,
            string sex, string headofhouse, string al1, string al2, string city, string province, string phone)       
        {
            string Stored_Procedure = "UpdatePatient";

            if (insert)
            {
                Stored_Procedure = "CreatePatient";
            }

            try
            {
                using (SqlCommand TempCmd = new SqlCommand(Stored_Procedure, con))
                {
                    TempCmd.CommandType = CommandType.StoredProcedure;

                    TempCmd.Parameters.Add("@HCN_param", SqlDbType.VarChar).Value = hcn;
                    TempCmd.Parameters.Add("@LastName_param", SqlDbType.VarChar).Value = lastname;
                    TempCmd.Parameters.Add("@FirstName_param", SqlDbType.VarChar).Value = firstname;
                    TempCmd.Parameters.Add("@mInitial_param", SqlDbType.VarChar).Value = minitial;
                    TempCmd.Parameters.Add("@DOB_param", SqlDbType.VarChar).Value = dob;
                    TempCmd.Parameters.Add("@sex_param", SqlDbType.VarChar).Value = sex;
                    TempCmd.Parameters.Add("@HOH_HCN_param", SqlDbType.VarChar).Value = headofhouse;
                    TempCmd.Parameters.Add("@addL1_param", SqlDbType.VarChar).Value = al1;
                    TempCmd.Parameters.Add("@addL2_param", SqlDbType.VarChar).Value = al2;
                    TempCmd.Parameters.Add("@city_param", SqlDbType.VarChar).Value = city;
                    TempCmd.Parameters.Add("@province_param", SqlDbType.VarChar).Value = province;
                    TempCmd.Parameters.Add("@Phone_param", SqlDbType.VarChar).Value = phone;
        
                    TempCmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                string error_msg = "update";

                if (insert)
                    error_msg = "insert into ";

                MessageBox.Show("Failed to " + error_msg + " database. Fatal Error. ", "Error");
                return;
            }
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
