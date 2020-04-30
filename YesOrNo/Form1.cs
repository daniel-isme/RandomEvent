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
            getAnswerButton.Enabled = true;
            answerLabel.ForeColor = Color.Gray;
        }

        private void getAnswerButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (rnd.NextDouble() < 0.5)
            {
                answerLabel.Text = "YES";
                answerLabel.ForeColor = Color.Green;
            }
            else
            {
                answerLabel.Text = "NO";
                answerLabel.ForeColor = Color.Red;
            }
            getAnswerButton.Enabled = false;
        }
    }
}
