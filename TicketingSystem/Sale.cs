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
        public void start()
        {
            string movie = SelectMovie.selected_movie;
            string time = TimeSelect.selected_time;
            createVoucher(movie,time);
            Seating seating = new Seating();
            seating.Show();
        }
        public void createVoucher(string movie,string time)
        {
            try
            {
                string insert = "INSERT INTO voucher(movie_name,show_time)VALUES('" + movie + "','"+time+"')";
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
      
        public void select_seat(string seat)
        {
            string id = getLastId();
            string seat_name = seat;
            char seat_id = seat_name[0];
            string movie_name = SelectMovie.selected_movie;
            record(id, seat_id, seat_name, movie_name);
     
            
        }
        public void record(string id, char s_id, string s_no, string movie_name)
        {
            try
            {
                string insert = "INSERT INTO sale(voucher_id,seat_id,seat_no,movie_name) VALUES('" + id + "','" + s_id + "','" + s_no + "','" + movie_name + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insert, connection);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void showVoucher()
        {

        }
        
    }
}
