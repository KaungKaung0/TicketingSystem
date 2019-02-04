using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TicketingSystem
{
    class Dbconnection
    {
        public Dbconnection()
        {
        }
        public bool Auth(string email, string password)
        {
            bool success = false;
            try
            {
                String connString = "Data Source=127.0.0.1;" + "Initial Catalog=cinema_ticket_system;" + "User id=root;" + "Password='';";
                MySqlConnection connc = new MySqlConnection(connString);
                String CommandText = "SELECT staff_email FROM staff WHERE staff_email= '" + email + "' AND staff_password = '" + password + "'";

                MySqlCommand command = new MySqlCommand(CommandText, connc);
                connc.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["staff_email"].ToString() == email)
                    {
                        MessageBox.Show("Success!");
                        success = true;
                    }
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Input");
                MessageBox.Show(ex.Message);
            }
            return success;
        }
    }
}



