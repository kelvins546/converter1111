using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converter1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, result;

            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);

            result = (num1 * num2)/2;
            MessageBox.Show("The area of a triangle is: " + result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
