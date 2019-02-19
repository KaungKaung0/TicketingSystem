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
    public partial class TimeSelect : Form
    {
        public static string selected_time = "";
        public TimeSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected_time = button1.Text;
            Sale select = new Sale();
            select.start();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sale select = new Sale();
            selected_time = button2.Text;
            select.start();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sale select = new Sale();
            selected_time = button3.Text;
            select.start();
            this.Hide();
        }

       
    }
}
