using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Events
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Button b = new Button();
            b.Text = "Click";
            b.Location = new Point(100, 100);
            this.Controls.Add(b);

            b.Click += new EventHandler(b_click);
        }
        void b_click(object sender,EventArgs e)
        {
            MessageBox.Show("Hello form2 from button");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
