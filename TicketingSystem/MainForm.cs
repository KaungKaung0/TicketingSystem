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
    public partial class MainForm : Form
    {

        public static string selected_movie = "";
        public static string selected_time = "";
        public static string selected_seat = "";
        public static int total_seat = 0;
        public static int total_price = 0;
        public static int seat_A_price, seat_B_price, seat_C_price;
        public static string date = "";
        string[] movie_receiver = new string[3];
        string[] price_receiver = new string[3];
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            string email, password;
            Boolean success = false;
            email = textBox1.Text;
            password = textBox2.Text;
            Authentication auth = new Authentication();
            success = auth.Auth(email, password);
            if (success)
            {
                LoginPanel.Visible = false;
                HomePanel.Visible = true;
            }
        }

        private void SelectMoviePanel_Paint(object sender, PaintEventArgs e)
        {
            Movie query = new Movie();
            movie_receiver = query.Show();
            FirstMovie.Text = movie_receiver[0];
            SecondMovie.Text = movie_receiver[1];
            ThirdMovie.Text = movie_receiver[2];
        }
        private void FirstMovie_Click(object sender, EventArgs e)
        {
            selected_movie = FirstMovie.Text;
            MovieLabel.Text = FirstMovie.Text;
            SelectMoviePanel.Visible = false;
            SelectTimePanel.Visible = true;
        }
        private void SecondMovie_Click(object sender, EventArgs e)
        {
            selected_movie = SecondMovie.Text;
            MovieLabel.Text = SecondMovie.Text;
            SelectMoviePanel.Visible = false;
            SelectTimePanel.Visible = true;
        }

        private void ThirdMovie_Click(object sender, EventArgs e)
        {
            selected_movie = ThirdMovie.Text;
            MovieLabel.Text = ThirdMovie.Text;
            SelectMoviePanel.Visible = false;
            SelectTimePanel.Visible = true;
        }
        private void BackToMovieSelect_Click(object sender, EventArgs e)
        {
            selected_time = "";
            SelectTimePanel.Visible = false;
            SelectMoviePanel.Visible = true;
        }
        private void FirstTime_Click(object sender, EventArgs e)
        {
            
            selected_time = FirstTime.Text;
            date = dateTimePicker1.Text;
            ShowDateLabel.Text = dateTimePicker1.Text;
            ShowTimeLabel.Text = selected_time;
            SelectTimePanel.Visible = false;
            ButtonCheck(SeatPanel, dateTimePicker1.Text);
            SeatPanel.Visible = true;
        }
        private void SecondTime_Click(object sender, EventArgs e)
        {
            
            selected_time = SecondTime.Text;
           
            date = dateTimePicker1.Text;
            ShowDateLabel.Text = dateTimePicker1.Text;
            ShowTimeLabel.Text = selected_time;
            SelectTimePanel.Visible = false;
            ButtonCheck(SeatPanel, dateTimePicker1.Text);
            SeatPanel.Visible = true;
        }

        private void ThirdTime_Click(object sender, EventArgs e)
        {
            
            selected_time = ThirdTime.Text;
          
            date = dateTimePicker1.Text;
            ShowDateLabel.Text = dateTimePicker1.Text;
            ShowTimeLabel.Text = selected_time;
            SelectTimePanel.Visible = false;
            ButtonCheck(SeatPanel, dateTimePicker1.Text);
            SeatPanel.Visible = true;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowDateLabel.Text = dateTimePicker1.Text;
        }

        private void BackToTimeSelect_Click(object sender, EventArgs e)
        {
            Sale record = new Sale();
            record.Clear(selected_movie, selected_time, dateTimePicker1.Text);
            selected_time = "";
            selected_seat = "";
            total_price = 0;
            SeatPanel.Visible = false;
            SelectTimePanel.Visible = true;
        }

        private void SeatPanel_Paint(object sender, PaintEventArgs e)
        {
            
                Sale sale = new Sale();
                price_receiver = sale.Seat_price();
                seat_A_price = int.Parse(price_receiver[0]);
                seat_B_price = int.Parse(price_receiver[1]);
                seat_C_price = int.Parse(price_receiver[2]);
                SeatAPriceTag.Text = "Seat A - " + price_receiver[0] + "Ks";
                SeatBPriceTag.Text = "Seat B - " + price_receiver[1] + "Ks";
                SeatCPriceTag.Text = "Seat C - " + price_receiver[2] + "Ks";
                TotalPrice.Text = total_price.ToString() + "Ks";


        }
        public static void ButtonCheck(Panel panel, string date)
        {
            Sale sale = new Sale();
            string[] bought_seat = sale.Bought_seat_id(selected_movie, selected_time, date);
            for (int i = 0; i < bought_seat.Length; i++)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is Button temp)
                    {
                        if (temp.Text == bought_seat[i])
                        {
                            temp.Enabled = false;
                        }
                    }

                }
            }
        }
        private void BtnA1_Click(object sender, EventArgs e)
        {

            selected_seat += btnA1.Text + ",";
            SelectedSeat.Text = selected_seat;
          
            total_price += seat_A_price;
            total_seat += 1;
            TotalPrice.Text = total_price.ToString() + "Ks";
            Sale temp = new Sale();
            temp.Record(null, btnA1.Text, selected_movie, selected_time, dateTimePicker1.Text);
        }

        private void BtnA2_Click(object sender, EventArgs e)
        {

            selected_seat += btnA2.Text + ",";
            SelectedSeat.Text = selected_seat;
            
            total_price += seat_A_price;
            total_seat += 1;
            TotalPrice.Text = total_price.ToString() + "Ks";
            Sale temp = new Sale();
            temp.Record(null, btnA2.Text, selected_movie, selected_time, dateTimePicker1.Text);
        }



        private void BtnB1_Click(object sender, EventArgs e)
        {
            selected_seat += btnB1.Text + ",";
            SelectedSeat.Text = selected_seat;
           
            total_price += seat_B_price;
            total_seat += 1;
            TotalPrice.Text = total_price.ToString() + "Ks";
            Sale temp = new Sale();
            temp.Record(null, btnB1.Text, selected_movie, selected_time, dateTimePicker1.Text);
        }



        private void BtnC1_Click(object sender, EventArgs e)
        {
            selected_seat += btnC1.Text + ",";
            SelectedSeat.Text = selected_seat;
           
            total_price += seat_C_price;
            total_seat += 1;
            TotalPrice.Text = total_price.ToString() + "Ks";
            Sale temp = new Sale();
            temp.Record(null, btnC1.Text, selected_movie, selected_time, dateTimePicker1.Text);
        }
        private void BtnSold_Click(object sender, EventArgs e)
        {
            Sale sold = new Sale();
            sold.CreateVoucher(dateTimePicker1.Text,selected_movie,selected_time,selected_seat,total_seat,total_price);
        }
    }
}
