using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LastWorkBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorCombControl1_SelectedColorChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form11 = new Form2();
            form11.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form12 = new Form3();
            form12.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form13 = new Form4();
            form13.Show();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
