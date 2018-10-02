using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PPE3_Stripscrabble
{
    public static class Modele
    {
        private static PPE3_StripscrabbleEntities connexion;
        private static Visiteur visiteurConnnecte;

        public static void init()
        {
            connexion = new PPE3_StripscrabbleEntities();
            visiteurConnnecte = new Visiteur();
        }

        public static string getIdVisiteur() { return visiteurConnnecte.idVisiteur; }
        public static int getIdLabo() { return visiteurConnnecte.idLabo; }
        public static string getNom() { return visiteurConnnecte.nom; }
        public static string getPrenom() { return visiteurConnnecte.prenom; }
        public static string getRue() { return visiteurConnnecte.rue; }
        public static string getCp() { return visiteurConnnecte.cp; }
        public static string getVille() { return visiteurConnnecte.ville; }
        public static string getDateEmbauche() { return visiteurConnnecte.dateEmbauche; }
        public static string getIdentifiant() { return visiteurConnnecte.identifiant; }
        public static string getPassword() { return visiteurConnnecte.password; }

        private static List<Visiteur> listeVisiteur()
        {
            return connexion.Visiteur.ToList();
        }

        public static bool verifierConnexion(string id, string mdp)
        {
            //permet de vérifier si le mot de passe entré, encodé en MD5, correspond à l'identifiant spécifié
            //En comparant chaque ligne de la base de données.
            //Renvoie Vrai si les deux correspondent, faux sinon.
            bool found = false;
            int i = 0;
            List<Visiteur> lesVisiteurs = listeVisiteur();
            while (!found && i < lesVisiteurs.Count)
            {
                Console.WriteLine(i);
                if(lesVisiteurs[i].identifiant == id && lesVisiteurs[i].password == GetMd5Hash(mdp))
                    //Si l'identifiant est dans la base, et si le mot de passe converti est dans la base
                    found = true;
                    //Alors on arrête la boucle et on certifie la validité.
                i++;
            }
            return found;
        }



        private static string GetMd5Hash(string PasswdSaisi)         
        {
            //Permet de retourner une chaine encryptée en MD5 en retirant les deux premiers caractères.
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }


        /*EXEMPLE DE METHODE POUR RECUPERER UNE TABLE
        
        public static List<VILLE> listeVilles()
        {
            return connexion.VILLE.ToList();
        }
        */


        /*EXEMPLE DE METHODE POUR RECUPERER UNE REQUETE
         * 
        public static Object CompositeursParStyle(int idStyle)
        {
            var LQuery = maConnexion.COMPOSITEUR.ToList()
                        .Where(x => x.idStyle == idStyle)
                        .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.anNais, x.anMort, x.remarque })
                        .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList();
        }
        */


    }
}
