using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void ShowValues_Click(object sender, EventArgs e)
        {
            int[] i = new int[] { 1, 4, 3, 665, 111, 556, 32, 1, 5, 6, 443, 5, 73, 2 };
            var v = from num in i select num;
            foreach(int i1 in v)
            {
               MessageBox.Show(v.ToString());
            }
        }

        private void AscVal_Click(object sender, EventArgs e)
        {
            int[] i = new int[] { 1, 4, 3, 665, 111, 556, 32, 1, 5, 6, 443, 5, 73, 2 };
            var v = from num in i orderby num ascending select num;
            foreach (int i1 in v)
            {
                MessageBox.Show(v.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
