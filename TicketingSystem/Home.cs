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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sale test = new Sale();
            string id = test.getLastId();
            Console.WriteLine(id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectMovie open = new SelectMovie();
            open.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMovie add = new AddMovie();
            this.Hide();
            add.Show();
        }
    }
}
