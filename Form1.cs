using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text != "")
           {
                label2.ForeColor = Color.Blue;
                label2.Text = textBox1.Text + " 先生，你好！";
           }
           else
           {
               return;
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label2.ForeColor = Color.Red;
                label2.Text = textBox1.Text + " 小姐，你好！";
            }
            else
            {
                return;
            }
        }
    }
}
