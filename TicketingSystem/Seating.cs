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
    public partial class Seating : Form
    {
        string[] receiver = new string[3];
        public static int seat_A, seat_B, seat_C;

        public Seating()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            select.select_seat(button10.Text);
            button10.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
         
         
            Sale select = new Sale();
            select.select_seat(button9.Text);
            button9.Enabled = false;
        }

  

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales voucher = new Sales();
            voucher.Show();
          
        }

        private void Seating_Load(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            receiver = sale.seat_price();
            label3.Text = "Seat A - " + receiver[0];
            label4.Text = "Seat B - " + receiver[1];
            label5.Text = "Seat C - " + receiver[2];
            seat_A = int.Parse(receiver[0]);
            seat_B = int.Parse(receiver[1]);
            seat_C = int.Parse(receiver[2]);
        }
    }
}
