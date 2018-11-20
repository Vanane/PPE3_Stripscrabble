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
        private static bool etatMedoc;

        public static void init()
        {
            connexion = new PPE3_StripscrabbleEntities();
            visiteurConnnecte = new Visiteur();
        }

        #region Getters/Setters
        //Liste des getters et setters de visiteurConnecté, mis en région pour masquer le bloc
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
        public static bool getEtatMedoc() { return etatMedoc; }

        public static void setIdVisiteur(string p) { visiteurConnnecte.idVisiteur = p; }
        public static void setIdLabo(int p) { visiteurConnnecte.idLabo = p; }
        public static void setNom(string p) { visiteurConnnecte.nom = p; }
        public static void setPrenom(string p) { visiteurConnnecte.prenom = p; }
        public static void setRue(string p) { visiteurConnnecte.rue = p; }
        public static void setCp(string p) { visiteurConnnecte.cp = p; }
        public static void setVille(string p) { visiteurConnnecte.ville = p; }
        public static void setDateEmbauche(string p) { visiteurConnnecte.dateEmbauche = p; }
        public static void setIdentifiant(string p) { visiteurConnnecte.identifiant = p; }
        public static void setPassword(string p) { visiteurConnnecte.password = p; }
        public static void setEtatMedoc(bool p) { etatMedoc = p; }
        #endregion


        public static bool verifierConnexion(string id, string mdp)
        {
            //Essaye de définir le Visiteur Connecté en récupérant le premier enregistrement
            //Qui possède les informations entrées.
            //Si les informations sont couplées, alors la connexion est établie, sinon
            //L'erreur générée par la requête comme quoi elle est vide est attrapée.
            bool r;
            string mdpHash = GetMd5Hash(mdp).ToUpper();

            try
            {
                Modele.visiteurConnnecte = VisiteurParSesId(id, mdpHash);
                r = true;
            }
            catch
            {
                r = false;
            }
            return r;
        }


        public static void resetConnexion()
        {
            init();
        }

        private static string GetMd5Hash(string PasswdSaisi)         
        {
            //Permet de retourner une chaine encryptée en MD5 en retirant les deux premiers caractères "0x".
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        private static Visiteur VisiteurParSesId(string id, string mdp)
        {
            //Retourne le premier visiteur, s'il y en a plusieurs, qui comporte un couple id/password.
            return connexion.Visiteur.Where(x => (x.identifiant == id) && (x.password == mdp)).First();
        }

        public static List<MEDECIN> listMedecin()
        {
            return connexion.MEDECIN.ToList();
        }

        public static List<MOTIF> listMotif()
        {
            return connexion.MOTIF.ToList();
        }

        public static List<MEDICAMENT> listMedoc()
        {
            return connexion.MEDICAMENT.ToList();
        }



        /*public static void leMedocEstPres()
        {
            medocEstPresente = true;
        }

        public static void leMedocEstEchan()
        {
            medocEstPresente = false;
        }*/

        /*EXEMPLE DE METHODE POUR RECUPERER UNE TABLE
        
        public static List<VILLE> listeVilles()
        {
            return connexion.VILLE.ToList();
        }
        */


        /*EXEMPLE DE METHODE POUR RECUPERER AVEC UNE REQUETE
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
