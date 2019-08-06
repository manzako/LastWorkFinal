using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LastWorkBD
{
   public class Operation
    {
       string chaine = @"Data Source=DESKTOP-VPOQSD0\MANZAKO; Initial Catalog=LASTWORKBD; Integrated Security=true";
       
       public int ecrire(string requete) {

           SqlConnection uneconnection = new SqlConnection(chaine);
           uneconnection.Open();
           SqlCommand macommande = new SqlCommand(requete,uneconnection);
           int nbre=macommande.ExecuteNonQuery();
           macommande.Dispose();
           uneconnection.Close();
           return nbre;
       }

       public void lire() { 
       
       }

    }
}
