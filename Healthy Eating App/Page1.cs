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
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            WelcomeLbl.Text = "Health Benfits of Pineapple's";
            descLbl.Text = "Pineapple's are famous for being one of the world's tastiest fruits." + Environment.NewLine +
            "pineapple is a crucial as a main or additional ingredient. Experts recommend that " + Environment.NewLine +
            "people should consume pineapple on at least a weekly basis. They" + Environment.NewLine +
            "vouch that pineapple can fit into any diet and that it will make" + Environment.NewLine +
            "a major improvement in one's health. This makes people wonder," + Environment.NewLine +
            "is pineapple really that good? Is a food this healthy a hoax?" + Environment.NewLine;
        }

        private void MealBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myMeal = new Meal();
            myMeal.ShowDialog();
            this.Close();
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            var myInfo = new Info();
            myInfo.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myLogIn = new LogIn();
            myLogIn.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
