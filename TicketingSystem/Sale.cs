using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TicketingSystem
{
    class Sale
    {
        MySqlConnection connection;

        public Sale()
        {
            string entry = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
            connection = new MySqlConnection(entry);
        }

        public string[] seat_price()
        {
            string[] data = new string[3];
            int i = 0;
            try
            {
                string get = "SELECT price FROM seat";
                connection.Open();
                MySqlCommand command = new MySqlCommand(get, connection);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                while (mySqlDataReader.Read())
                {

                    data[i] = mySqlDataReader["price"].ToString();
                    i++;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return data;
        }

    }
}
