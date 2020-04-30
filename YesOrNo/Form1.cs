using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YesOrNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageTextBox_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "-";
            answerLabel.ForeColor = Color.Gray;
        }

        private Random rnd = new Random();

        private void getAnswerButton_Click(object sender, EventArgs e)
        {
            double alpha = rnd.NextDouble();
            double chance = chanceTrackBar.Value / 100.0;

            if (alpha < chance)
            {
                answerLabel.Text = "YES";
                answerLabel.ForeColor = Color.Green;
            }
            else
            {
                answerLabel.Text = "NO";
                answerLabel.ForeColor = Color.Red;
            }
        }

        private void chanceTrackBar_Scroll(object sender, EventArgs e)
        {
            chanceValueLabel.Text = $"{chanceTrackBar.Value}%";
        }
    }
}
