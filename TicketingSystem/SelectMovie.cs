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
            string movie= button1.Text;
            this.Hide();
            Sale select = new Sale();
            select.movie_select(movie);
        }
    }
}
