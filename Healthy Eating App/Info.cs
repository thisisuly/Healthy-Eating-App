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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            {
                benefitRTBox.SelectionFont = new Font("Tahoma", 10, FontStyle.Bold);
                benefitRTBox.AppendText("1. Vision Improvement");
                benefitRTBox.AppendText(Environment.NewLine);
                benefitRTBox.SelectionFont = new Font("Tahoma", 8, FontStyle.Regular);
                benefitRTBox.AppendText("Insert Text Here");
                benefitRTBox.AppendText(Environment.NewLine);
                benefitRTBox.AppendText(Environment.NewLine);
                benefitRTBox.SelectionFont = new Font("Tahoma", 10, FontStyle.Bold);
                benefitRTBox.AppendText("2.Inflammation Relief");
                benefitRTBox.SelectionFont = new Font("Tahoma", 8, FontStyle.Regular);
                benefitRTBox.AppendText(Environment.NewLine + "Insert Text Here");
                benefitRTBox.AppendText(Environment.NewLine);
                benefitRTBox.AppendText(Environment.NewLine);
                benefitRTBox.SelectionFont = new Font("Tahoma", 10, FontStyle.Bold);
                benefitRTBox.AppendText("3. Cancer Prevention");
                benefitRTBox.AppendText(Environment.NewLine);
                benefitRTBox.SelectionFont = new Font("Tahoma", 8, FontStyle.Regular);
                benefitRTBox.AppendText("Insert Text Here");
            }
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
