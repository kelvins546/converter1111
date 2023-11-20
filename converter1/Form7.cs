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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, result;

            num1 = int.Parse(textBox1.Text);
            num2 = int.Parse(textBox2.Text);

            result = num1 + num2;
            MessageBox.Show("The perimeter of a rectangle is: " + result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
