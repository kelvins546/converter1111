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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
            this.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form = new Form9();
            form.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
