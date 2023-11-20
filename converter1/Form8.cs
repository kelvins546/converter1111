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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, result;

            num1 = int.Parse(textBox1.Text);


            result = num1 * 4;
            MessageBox.Show("The perimeter of Square is: " + result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
