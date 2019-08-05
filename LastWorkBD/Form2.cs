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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form11 = new Form1();
            form11.Show();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
