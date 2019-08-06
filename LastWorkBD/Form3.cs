using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LastWorkBD
{
    public partial class Form3 : Form
    {
        public string chaine1 = @"Data Source=DESKTOP-VPOQSD0\MANZAKO; Initial Catalog=LASTWORKBD; Integrated Security=true";
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string question1 = "SELECT * FROM CD";
            lire(question1);
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
            string requete22 = "SELECT PARTICIPANT.NOM_PARTICIPANT AS PARTICIPANT, PARTICIPANT.NATURE_PART AS NATURE,PLAGE.NOM_PLAGE AS PLAGE,PLAGE.FAMILLE AS FAMILLE,PLAGE.GENRE AS GENRE FROM PARTICIPANT,PLAGE";
            lire(requete22);
        }
        public void lire( string requete)
        {
            SqlConnection first = new SqlConnection(chaine1);
            try {

                first.Open();
                SqlDataAdapter adaptation = new SqlDataAdapter(requete,first);
                DataSet second = new DataSet();
                adaptation.Fill(second, "PARTICIPANT");
                dataGridView1.DataSource=second.Tables["PARTICIPANT"];
                first.Close();

            }
            catch(Exception ex){
                MessageBox.Show("Erreur "+ ex);
            
            
            }

        }

        private void PLAGE_Click(object sender, EventArgs e)
        {
            string question = "SELECT * FROM PLAGE";
            lire(question);
        }

    }
}
