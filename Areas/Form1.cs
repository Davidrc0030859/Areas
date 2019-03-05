
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Areas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            double length = double.Parse(richTextBox1.Text);
            double width = double.Parse(richTextBox2.Text);
            double area = length * width;
            richTextBox3.AppendText(area.ToString());
            
        }
    }
}
  .

...
3
