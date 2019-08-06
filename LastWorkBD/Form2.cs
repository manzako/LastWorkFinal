using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace LastWorkBD
{
    public partial class Form2 : Form
    {
        public int idp1, nplg1, idcd1, nedt1;
        public string nmp, nap, inst, npl, fam, gen, tit, edt, aned, col;
        public string hererequete1;
        public string hererequete2;
        public string hererequete3;
        public string hererequete4;
        public string hererequete5;
        public string hererequete6;
        
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
        private void initialiser() {

            IDPARTICIPANT.Text = "";
            NOMPARTICIPANT.Text = "";
            NATUREPARTICIPANT.Text = "";
            INSTRUMENT.Text = "";
            NPLAGE.Text = "";
            NOMPLAGE.Text = "";
            FAMILLE.Text = "";
            GENRE.Text = "";
            IDCD.Text = "";
            TITRECD.Text = "";
            NDEDITION.Text = "";
            EDITEUR.Text = "";
            ANNEEEDITION.Text = "";
            COLLECTION.Text = "";

        }

        public void parametrage() {

            conversionchiffre();
           // recuperattext();
           

        }
        private void recuperattext(){
            nmp = NOMPARTICIPANT.Text;
            nap=NATUREPARTICIPANT.Text;
            inst=INSTRUMENT.Text;
            npl= NOMPLAGE.Text;
            fam= FAMILLE.Text;
            gen= GENRE.Text;
            tit= TITRECD.Text;
            edt= EDITEUR.Text;
            aned= ANNEEEDITION.Text;
            col= COLLECTION.Text;
        }
        public void conversionchiffre() {
            int idp, nplg, idcd, nedt;
            if (int.TryParse(IDPARTICIPANT.Text, out idp) && int.TryParse(NPLAGE.Text, out nplg) && int.TryParse(NDEDITION.Text, out nedt) && int.TryParse(IDCD.Text, out idcd))
            {
                //Ajout ou Insertion des données dans la table PARTICIPANT
                idp1 = idp;
                recuperattext();
                hererequete2 = "Insert into PARTICIPANT(ID_PARTICIPANT,NOM_PARTICIPANT,NATURE_PART,INSTRUMENT) values(" + idp1 + ",\'" + nmp + "\',\'" + nap + "\',\'" + inst + "\')";
                Operation op2 = new Operation();
                op2.ecrire(hererequete2);
               // MessageBox.Show("Ajout participant reussi");
                //Ajout ou Insertion des données dans la table PLAGE
                nplg1 = nplg;
                recuperattext();
                hererequete1 = "Insert into PLAGE(NPLAGE,NOM_PLAGE,FAMILLE,GENRE) values(" + nplg1 + ",\'" + npl + "\',\'" + fam + "\',\'" + gen + "\')";
                Operation op1 = new Operation();
                op1.ecrire(hererequete1);
                //MessageBox.Show("ajout plage reussi");
                //Ajout ou Insertion des données dans la table  EDITION
                nedt1 = nedt;
                recuperattext();
                hererequete3 = "Insert into EDITION(N_EDITION,EDITEUR,ANNEE_EDITION,COLLECTIONN) values(" + nedt1 + ",\'" + edt + "\',\'" + aned + "\',\'" + col + "\')";
                Operation op3 = new Operation();
                op3.ecrire(hererequete3);
               // MessageBox.Show("Ajout Edition reussi");
                //Ajout ou Insertion des données dans la table CD
                idcd1 = idcd;
                recuperattext();
                hererequete4 = "Insert into CD(ID_CD,TITRE_CD,N_EDITION) values(" + idcd1 + ",\'" + tit + "\'," + nedt1 + ")";
                Operation op4 = new Operation();
                op4.ecrire(hererequete4);
                //MessageBox.Show("ajout CD reussi");
                //Ajout ou Insertion des donnees dans nos tables qui n'ont que des clés etrangères, à savoir PARTICIPER ET APPARTENIR
                hererequete5 = "Insert into PARTICIPER(ID_PARTICIPANT,NPLAGE) values ("+idp1+","+nplg1+")";
                hererequete6 = "Insert into APPARTENIR(NPLAGE,ID_CD) values ("+nplg1+","+idcd1+")";
                Operation op5 = new Operation();
                op5.ecrire(hererequete5);
                op5.ecrire(hererequete6);
                MessageBox.Show("Ajout Reussi");
                initialiser();

            }else{
                MessageBox.Show("Identifiant en chiffre svp");
                IDPARTICIPANT.Text = "";
                NPLAGE.Text = "";
                NDEDITION.Text = "";
                IDCD.Text = "";
            }
           
        }
        private void verification() {

            if (IDPARTICIPANT.Text == "" || NOMPARTICIPANT.Text == "" || NATUREPARTICIPANT.Text == "" || INSTRUMENT.Text == "" || NPLAGE.Text == "" || NOMPLAGE.Text == "" || FAMILLE.Text == "" || GENRE.Text == "" || IDCD.Text == "" || TITRECD.Text == "" || NDEDITION.Text == "" || EDITEUR.Text == "" || ANNEEEDITION.Text == "" || COLLECTION.Text == "")
            {
                MessageBox.Show("Remplir tous les champs svp!!!!");
            }
            else {

                parametrage();
            }
        }

        private void ANNULER_Click(object sender, EventArgs e)
        {
            initialiser();
        }

        private void SAUVER_Click(object sender, EventArgs e)
        {
            try
            {
                verification();
                               
            }
            catch(Exception EX){

                MessageBox.Show("Erreur "+EX);
            
            }
        }

        private void NATUREPARTICIPANT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] Tab = new string[]{"CLASSIQUE","JAZZ","VARIETES","FOLKLORE","INTERNATIONAL"};
            string[] Tab1 = new string[] { "VALSE", "ROCK", "MAMBO", "LIEDER" };
            string[] Tab2 = new string[] {"COMPOSITEUR","AUTEUR","ARRANGEUR OU ORCHESTRATEUR","PRODUCTEUR","CHANTEUR" };

            foreach (string nom in Tab) {
                FAMILLE.Items.Add(nom);
            }
            foreach (string nom1 in Tab1)
            {
                GENRE.Items.Add(nom1);
            }

            foreach (string nom2 in Tab2)
            {
                NATUREPARTICIPANT.Items.Add(nom2);
            }
           
        }
        

    }
}
