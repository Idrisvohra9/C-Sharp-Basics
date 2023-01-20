using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eventdelegate
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "Click Me";
            b.Size = new Size(100, 100);
            b.Location = new Point(100, 100);
            this.Controls.Add(b);
            b.Click += delegate(object sender1, EventArgs e1)
            {
                MessageBox.Show("hello");

            };





          //  Button b = new Button();
          //  b.Text = "Click Me";
          //  b.Size = new Size(100, 100);
          //  b.Location = new Point(150, 150);
          //  this.Controls.Add(b);
          ////  b.Click += new EventHandler(b_Click);
          //  b.Click += delegate(object sender1,EventArgs e1)
          //  {
          //      MessageBox.Show("hello");
          //  };
        }
        //private void b_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("hello");
        //}
    }
}
