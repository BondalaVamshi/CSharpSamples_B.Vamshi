using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Asynchronous_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharecters()
        {
            int count = 0;
            using(StreamReader reader=new StreamReader("E:\\C#.net\\MessageHello.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(1000);
            }
            return count;
        }
        private async void btnCount_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharecters);
            task.Start();
            lblMessage.Text = "counting started....";
            int count = await task;
            lblMessage.Text = count.ToString()+" is the number of charecters";

            //int count = 0;
            //Thread thread=new Thread(()=>{ count = CountCharecters(); });
            //thread.Start();
            //lblMessage.Text = "counting started....";
            //thread.Join();
            //lblMessage.Text = count + " is the number of characters";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
