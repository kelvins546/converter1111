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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kelvin Arnold Manalad\nBSIT-1A \nSubject C#", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }
    }
    }

