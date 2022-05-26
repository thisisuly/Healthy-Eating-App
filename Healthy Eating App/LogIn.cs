using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthy_Eating_App
{
    public partial class LogIn : Form
    {
        // define usernames and passwords
        String[] username = new string[] { "Ulysse", "Oscar", "Patsy" };
        String[] password = new string[] { "Password", "Password1", "Password2" };
        // define logged in state
        bool loggedIn;
        // define logged in username
        string loggedInUser;

        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {   // set logged in state to false
            loggedIn = false;
            // loop through usernames and passwords
            for (int index = 0; index < 3; index++)

            { // check if the usernames and passwords match
                if (UserTBox.Text == username[index] && PassTBox.Text == password[index])
                {
                    // set logged in state to true
                    loggedIn = true;
                    loggedInUser = username[index];
                }
            }
            if (loggedIn)
            {
                // if logged in state true open up page 1 form
                this.Hide();
                var myForm = new Page1();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                // show error message
                MessageBox.Show("Please enter a correct username and password");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            // exit application
            Application.Exit();
        }
    }
}
