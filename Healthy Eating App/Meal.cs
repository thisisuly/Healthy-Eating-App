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
    public partial class Meal : Form
    {
        public Meal()
        {
            InitializeComponent();
        }

        private void Meal_Load(object sender, EventArgs e)
        {
            this.Text = "A healthy meal recipe";
            mealLbl.Text = "How to make a pineapple smoothie";
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe width="560" height="315" src="https://www.youtube.com/embed/OpZ84Jwade8 title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = html;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myMenu = new Page1();
            myMenu.ShowDialog();
            this.Close();
        }
    }
}
