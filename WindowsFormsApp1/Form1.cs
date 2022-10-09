using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string msg;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputTxt = input.Text.ToLower();
            string tmp = "";
            for (int i = inputTxt.Length-1; i >= 0; i--)
            {
                tmp += inputTxt[i];
            }
            if (tmp.Equals(inputTxt))
            {
                msg = $"{inputTxt} is a palindrome.";
            }
            else
            {
                msg = $"{inputTxt} is not a palindrome.";
            }
            msgLabel.Text = msg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
