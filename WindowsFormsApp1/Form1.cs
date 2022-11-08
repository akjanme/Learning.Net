using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Guruji"
                && textBox2.Text == "BhoolGya")
            {
                label3.Text = "Welcome!";
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.Text = "User Name/Password is incorrect!";
                label3.ForeColor = Color.Red; 
            }
        }
    }
}
