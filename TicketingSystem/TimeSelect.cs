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
        public TimeSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sale select = new Sale();
            select.time_select(button1.Text);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sale select = new Sale();
            select.time_select(button2.Text);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sale select = new Sale();
            select.time_select(button3.Text);
            this.Hide();
        }
    }
}
