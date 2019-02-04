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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email, password;
            Boolean success=false;
            email = textBox1.Text;
            password = textBox2.Text;
            Authentication auth = new Authentication();
            success = auth.Auth(email, password);
            if(success)
            {
                this.Hide();
                SelectMovie open = new SelectMovie();
                open.Show();
            }
    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
