using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace TicketingSystem
{
    class Sale
    {
        readonly MySqlConnection connection;


        public Sale()
        {
            string entry = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
            connection = new MySqlConnection(entry);
        }

        public string[] Seat_price()
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
        public void CreateVoucher(string date,string movie,string time,string seat,int total_seat,int price)
        {
            try
            {
                string insert = "INSERT INTO voucher(date,movie_name,show_time,seat_no,total_seats,total_amount)VALUES('" + date + "','" + movie + "','" + time + "','" + seat + "','" + total_seat + "','" + price + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insert, connection);
                MySqlDataReader reader = command.ExecuteReader();
                connection.Close();
                ConfirmSold(movie, time, date);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Failed");

            }
           
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
                }
                connection.Close();
                if (String.IsNullOrEmpty(v_id))
                {
                    Console.WriteLine("Null");

                }
                else
                {
                    return v_id;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return "Null";

        }
        public void ConfirmSold(string movie,string time,string date)
        {
            Console.WriteLine("sold");
            string id = getLastId();
            try
            {
                string update = "UPDATE sale SET confirm = '"+1+ "' ,voucher_id = '"+id+"'  WHERE movie_name = '" + movie + "' AND time ='" + time + "' AND date= '" + date + "'";
                connection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(update, connection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Record(string id,string s_no, string movie_name,string time,string date)
        {
            try
            {
                string insert = "INSERT INTO sale(voucher_id,seat_no,movie_name,time,date,confirm) VALUES('" + id + "','" + s_no + "','" + movie_name + "','" + time + "','" + date + "','"+0+"')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insert, connection);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Clear(string selected_movie,string selected_time,string date)
        {
            try
            {
                string delete = "DELETE FROM sale WHERE movie_name = '" + selected_movie + "' AND time ='" + selected_time + "' AND date= '" + date + "' AND confirm = '" + 0 + "' ";
                connection.Open();
                MySqlCommand command = new MySqlCommand(delete, connection);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public string[] Bought_seat_id(string movie,string time,string date)
        {
            string[] data = new string[50];
            int i = 0;
            try
            {
                string get = "SELECT seat_no FROM sale WHERE movie_name = '" + movie + "' AND time ='"+time+"' AND date= '"+date+"' AND confirm = '"+1+"'";
                connection.Open();
                MySqlCommand command = new MySqlCommand(get, connection);
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    data[i] = mySqlDataReader["seat_no"].ToString();
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
