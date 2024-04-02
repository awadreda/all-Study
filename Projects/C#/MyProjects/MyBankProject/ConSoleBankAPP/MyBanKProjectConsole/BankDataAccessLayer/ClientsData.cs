using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BankDataAccessLayer
{
    public class ClientsData
    {

        public static bool getClinet(int ID, ref string FirstName, ref string LastName, ref string Email, ref string Phone, ref string AccountNumber
          ,ref string PINCODE,ref float AccountBalance)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(DataConnectionSettings.ConnectionString);

            string query = @"select *from Clients2 where ClientID=@ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                
                if(reader.Read())
                {

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    AccountNumber = (string)reader["AccountNumber"];
                    PINCODE = (string)reader["PINCode"];
                    AccountBalance = Convert.ToSingle( reader["AccountBalance"]);



                }

                reader.Close();

                isFound = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("erro " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }


            return isFound;
            
        }




    }
}
