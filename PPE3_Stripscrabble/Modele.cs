using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

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



        public static bool verifierConnexion()
        {
            bool reponse;


            return reponse;
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
