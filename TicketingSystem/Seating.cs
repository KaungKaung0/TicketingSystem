﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketingSystem
{
    public partial class Seating : Form
    {
        public Seating()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Seating_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sale select = new Sale();
            select.select_seat(button1.Text);
            button1.Enabled = false; 
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Sale select = new Sale();
            select.seat_select(button10.Text);
            button10.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void Confirm_Click(object sender, EventArgs e)
        {

            this.Hide();
            Sales saleform = new Sales();
            saleform.Show();
        }

        
    }
}
