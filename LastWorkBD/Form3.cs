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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form15 = new Form1();
            form15.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
