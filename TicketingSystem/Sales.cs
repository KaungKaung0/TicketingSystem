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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.sold_confirm();
            MessageBox.Show("You have purchased successfully");
            this.Close();
            Home new_home = new Home();
            new_home.Show();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            label9.Text = TimeSelect.date;
            label10.Text = SelectMovie.selected_movie;
            label11.Text = sale.getHall();
            label12.Text = TimeSelect.selected_time;
            label13.Text = sale.getAllSeats();
            label14.Text = sale.calcTotal();
        }
    }
}
