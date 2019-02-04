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
        int i = 0;
        public Sale()
        {
            string entry = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
            connection = new MySqlConnection(entry);
        }
        public void movie_select(string movie)
        {
                selected_movie = movie;
            Console.WriteLine(movie);
                TimeSelect time = new TimeSelect();
                time.Show();
        }
        public void time_select(string time)
        {
            time_selected = time;
            Console.WriteLine(time);
            Seating seat = new Seating();
            seat.Show();
        }
        public void seat_select(string seat)
        {
            total_seat[i] = seat;
            i++;
            test();
        }
        public void test()
        {
            try
            {
                for(int j=0; j<= total_seat.Length; j++)
                {
                    Console.WriteLine(total_seat[j]);
                }
            }
            catch(Exception ex)
            {
               
            }
        }
    }
}
