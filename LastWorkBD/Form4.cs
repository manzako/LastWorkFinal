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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form14 = new Form1();
            form14.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'LASTWORKBDDataSet.PARTICIPANT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.PARTICIPANTTableAdapter.Fill(this.LASTWORKBDDataSet.PARTICIPANT);
            // TODO: cette ligne de code charge les données dans la table 'LASTWORKBDDataSet.PLAGE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.PLAGETableAdapter.Fill(this.LASTWORKBDDataSet.PLAGE);
            // TODO: cette ligne de code charge les données dans la table 'LASTWORKBDDataSet.EDITION'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.EDITIONTableAdapter.Fill(this.LASTWORKBDDataSet.EDITION);
            // TODO: cette ligne de code charge les données dans la table 'LASTWORKBDDataSet.CD'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.CDTableAdapter.Fill(this.LASTWORKBDDataSet.CD);

            this.reportViewer1.RefreshReport();
        }
    }
}
