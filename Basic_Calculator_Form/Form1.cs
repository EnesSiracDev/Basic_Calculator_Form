using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Addition");
            comboBox1.Items.Add("Subtraction");
            comboBox1.Items.Add("Multiplication");
            comboBox1.Items.Add("Division");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operation operation = new Operation(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            switch (comboBox1.Text)
            {
                case "Addition":
                    MessageBox.Show(operation.Addition().ToString());
                    break;
                case "Subtraction":
                    MessageBox.Show(operation.Subtraction().ToString());
                    break;
                case "Multiplication":
                    MessageBox.Show(operation.Multiplication().ToString());
                    break;
                case "Division":
                    MessageBox.Show(operation.Division().ToString());
                    break;
            }
        }
    }
}
