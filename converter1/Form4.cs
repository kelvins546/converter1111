using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace converter1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  num1, result;

            num1 = int.Parse(textBox1.Text);
            

            result = num1 * num1;
            MessageBox.Show("The area of Square is: " + result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
