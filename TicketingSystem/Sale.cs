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
        string seat_selected;
        string[] total_seat = new string[60];
        public Sale()
        {
            string entry = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
            connection = new MySqlConnection(entry);
        }
        public String getLastId()
        {
            string v_id = null;
            try
            {
                string query = "SELECT voucher_id FROM voucher ORDER BY voucher_id DESC LIMIT 1";
                connection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    v_id = reader["voucher_id"].ToString();
                    if (String.IsNullOrEmpty(v_id))
                    {
                        Console.WriteLine("Null");
                      
                    }
                    else
                    {
                        connection.Close();
                        return v_id;

                    }
                }
                
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return "Null";
            
        }
        public void movie_select(string movie)
        {
            createVoucher(movie);
            TimeSelect time = new TimeSelect();
            time.Show();
        }
        public void createVoucher(string movie)
        {
            try
            {
                string insert = "INSERT INTO voucher(movie_name)VALUES('" + movie + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insert, connection);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Failed");

            }   
                           
        }
        public void time_select(string time)
        {
            string id = getLastId();
            addTime(time,id);
            Seating seat = new Seating();
            seat.Show();
        }
        public void addTime(string time,string id)
        {
            
            try
            {
                string update = "UPDATE voucher SET show_time  = '" + time + "' WHERE voucher_id = '" + id +"' ";
                connection.Open();
                MySqlCommand command = new MySqlCommand(update, connection);
                MySqlDataReader reader = command.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void select_seat(string seat)
        {
            string id = getLastId();

            
        }
        
    }
}
