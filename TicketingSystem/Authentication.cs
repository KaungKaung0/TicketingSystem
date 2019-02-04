using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace TicketingSystem
{
    class Authentication
    {
        public bool Auth(string email,string password)
        {
            bool success=false;
            try
            {
                string entry = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
                MySqlConnection conn = new MySqlConnection(entry);
                string query = "SELECT staff_email FROM staff WHERE staff_email='" + email + "' AND staff_password='" + password + "'";
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if(reader["staff_email"].ToString() == email)
                    {
                        success = true;
                    }
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return success;
        }
    }
}
