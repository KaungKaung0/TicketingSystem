using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketingSystem
{
    public partial class SelectMovie : Form
    {
        public static string selected_movie = "";
        string[] receiver = new string[3];
        public SelectMovie()
        {
            InitializeComponent();
        }

        private void SelectMovie_Load(object sender, EventArgs e)
        {
            Movie query = new Movie();
            receiver = query.Show();
            button1.Text = receiver[0];
            button2.Text = receiver[1];
            button3.Text = receiver[2];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            selected_movie = button1.Text;
            this.Close();
            TimeSelect timeSelect = new TimeSelect();
            timeSelect.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selected_movie = button2.Text;
            this.Close();
            TimeSelect timeSelect = new TimeSelect();
            timeSelect.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selected_movie = button3.Text;
            this.Close();
            TimeSelect timeSelect = new TimeSelect();
            timeSelect.Show();
        }
    }
}
