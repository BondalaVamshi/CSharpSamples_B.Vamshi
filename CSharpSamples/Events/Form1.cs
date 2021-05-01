using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.Run(new Form2());


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "the Check Box is Checked";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello all of you ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
