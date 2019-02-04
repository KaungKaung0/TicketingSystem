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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seating seatingForm = new Seating();
            seatingForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seating seatingForm = new Seating();
            seatingForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seating seatingForm = new Seating();
            seatingForm.Show();
        }

        private void SelectMovie_Load(object sender, EventArgs e)
        {

            Movie movie = new Movie();
            receiver = movie.Show();
           for(int i=0; i<= receiver.Length; i++) {
                for(int j = 0; j <= receiver.Length; j++)
                {
                    MessageBox.Show(receiver[j]);
                }
            }
            
        }
    }
}
