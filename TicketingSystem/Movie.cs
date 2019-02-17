using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace TicketingSystem
{
    class Movie
    {
        MySqlConnection connection;
        
        public Movie()
        {
            string entry = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
            connection = new MySqlConnection(entry);
        }
        public void Insert(string name,string category)
        {
            try
            {
                
                string insert = "INSERT INTO movie(movie_name,movie_genre) VALUES('"+name+"','"+category+"')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insert, connection);
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Success!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Failed.");
            }
        }
        public string[] Show()
        {
            string[] name = new string[3];
            int i=0;
            try
            {
               
                string query = "SELECT movie_name FROM movie ORDER BY movie_id DESC LIMIT 3";
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader(); 
                while(reader.Read())
                {
                    name[i] = reader["movie_name"].ToString();
                    Console.WriteLine(name[i]);
                    i++;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return name;
        }
       
    }
}
