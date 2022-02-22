using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSimpelRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_equals.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            button_equals.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            label3.Visible = true;
            double zahl1 = Convert.ToDouble(textBox1.Text);
            double zahl2 = Convert.ToDouble(textBox2.Text);
            string output = Convert.ToString(zahl1 + zahl2);
            textBox3.Text = output;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            button_equals.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
