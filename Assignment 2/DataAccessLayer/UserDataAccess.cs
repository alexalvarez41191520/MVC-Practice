using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using Assignment_2.Models;

namespace Assignment_2.DataAccessLayer
{
    public class UserDataAccess
    {
        public Boolean GetUser(string usernameI, string passwordI)
        {
            List<User> products = new List<User>();
            String connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                String query = "SELECT * FROM customer  WHERE customer_name='" + usernameI + "' AND customer_email ='" + passwordI + "'";
                SqlCommand cmd = new SqlCommand(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Reads the first row of the result set
                    {
                        /*User.Add(new User
                        {
                            customer_id = Int32.Parse(reader["customer_id"].ToString()),
                            customer_name = reader["customer_name"].ToString(),
                            customer_email = reader["customer_email"].ToString()

                        });*/
                        return true;
                    }
                    reader.Close();
                }
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                sqlConnection.Close();
            }
            return true;
        }

        public void AddCustomer(int customer_id, strong customer_name, string customer_email)
        {
            String connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                sqlConnection.Close();
            }
        }

    }
}