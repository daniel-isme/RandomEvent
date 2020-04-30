using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace YesOrNo
{
    public partial class Form1 : Form
    {

        private Random rnd = new Random();
        private List<AnswerModel> answers;
        private string workingDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"));
        private List<double> p = new List<double>();

        public Form1()
        {
            InitializeComponent();
            StreamReader r = new StreamReader(workingDirectory + "Answers.json");
            string jsonString = r.ReadToEnd();
            answers = JsonConvert.DeserializeObject<List<AnswerModel>>(jsonString);
            
            for (int i = 0; i < answers.Count - 2; i++)
            {
                p.Add(rnd.NextDouble());
            }
            p.Add(0);
            p.Add(1);
            p.Sort();

            // get lengths
            for (int i = 0; i < p.Count - 1; i++)
            {
                for (int j = i + 1; j < p.Count; j++)
                {
                    p[j] -= p[i];
                }
            }
        }

        private void messageTextBox_Click(object sender, EventArgs e)
        {
            answerLabel.Text = "-";
            answerLabel.ForeColor = Color.Gray;
        }

        private void getAnswerButton_Click(object sender, EventArgs e)
        {
            double alpha = rnd.NextDouble();

            int k = 1;
            double A = alpha;

            A -= p[k];
            while (A > 0)
            {
                k++;
                A -= p[k];
            }

            answerLabel.Text = answers[k].Text;

            switch (answers[k].Type)
            {
                case "positive":
                    answerLabel.ForeColor = Color.Green;
                    break;
                case "neutral":
                    answerLabel.ForeColor = Color.Goldenrod;
                    break;
                case "nagative":
                    answerLabel.ForeColor = Color.Red;
                    break;
                default:
                    answerLabel.ForeColor = Color.Black;
                    break;
            }
        }
    }
}
