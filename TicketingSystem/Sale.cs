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
        string selected_movie,time_selected,seat_selected;
        string[] total_seat = new string[60];
        public Sale()
        {
            string entry = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
            connection = new MySqlConnection(entry);
        }
        public void openSale(string movie_name)
        {
            getLastId();
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
            selected_movie = movie;
            createVoucher(selected_movie);
            TimeSelect time = new TimeSelect();
            time.Show();
        }
        public void createVoucher(string movie)
        {
            try
            {
                string insert = "INSERT INTO voucher(voucher_id,show_time,movie_name,theater_name,seat_no,total_seat,total_amount,paid_amount,change_amount)VALUES(0,'not defined','" + movie + "','not defined','not defined',0,0,0,0)";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insert, connection);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Failed");

            }
            
                           
        }
        public void time_select(string time)
        {
            time_selected = time;
            Console.WriteLine(time_selected);
            Seating seat = new Seating();
            seat.Show();
        }
        public void addTime(string time)
        {

        }
        public void seat_select(string seat)
        {
            Console.WriteLine(selected_movie);
            
        }
        
    }
}
