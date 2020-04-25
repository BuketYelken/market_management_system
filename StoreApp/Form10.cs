using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
               if(textBox1.Text == "admin" && textBox2.Text == "123")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
               else if(textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Please type username and password", "Warning");
            }
            else
            {
                MessageBox.Show("Please check username and password", "Warning");
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
