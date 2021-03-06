﻿using System;
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
        private static string typeDemande;

        private static int QteNuit;
        private static int QteRepas;
        private static int QteVehicule;

        private static DateTime dateHF;
        private static string libelleHF;
        private static double MontantHf;
        private static int dateduMois;

     
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

        public static fichefrais getLaFicheFrais()
        {
            return visiteurConnnecte.fichefrais.Where(x => x.mois == DateTime.Now.Month.ToString()).First();
            // && x.mois == DateTime.Now.Year.ToString()
        }
        public static List<LigneFraisForfait> getLesLignesForfait()
        {
            /*   var LQuery = maConnexion.COMPOSITEUR.ToList()
                        .Where(x => x.idStyle == 1)
                        .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.anNais, x.anMort, x.remarque })
                        .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList(); */

            List<LigneFraisForfait> l = connexion.LigneFraisForfait
                            .Where(x => x.mois == DateTime.Now.Month.ToString() && x.idVisiteur == visiteurConnnecte.idVisiteur).ToList();
            return l;
        }

        public static List<LigneFraisHorsForfait> getLesLignesHorsForfait()
        {
            List<LigneFraisHorsForfait> l = connexion.LigneFraisHorsForfait
                            .Where(x => x.mois == DateTime.Now.Month.ToString() && x.idVisiteur == visiteurConnnecte.idVisiteur).ToList();
            return l;
        }

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



        public static DateTime DateHF { get => dateHF; set => dateHF = value; }
        public static string LibelleHF { get => libelleHF; set => libelleHF = value; }
        public static double MontantHF { get => MontantHf; set => MontantHf = value; }
        public static int DateduMois { get => dateduMois; set => dateduMois = value; }
        public static int QteNuit1 { get => QteNuit; set => QteNuit = value; }
        public static int QteRepas1 { get => QteRepas; set => QteRepas = value; }
        public static int QteVehicule1 { get => QteVehicule; set => QteVehicule = value; }

        public static void setTypeDemande(string s) { typeDemande = s; }
        public static string getTypeDemande() { return typeDemande; }
       

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
        // Repris de MusicAtout
        public static bool ModifDemandeForfaitisé( double Montant, int Quantite, double Prix , string mois)
        {
            bool vretour = true;
            try
            {

            }catch(Exception e)
            {
                vretour = false;
            }
            return vretour;
            
        }
        
        public static bool ModifDemandeHorsForfait ( DateTime dateHorsForfait, string libHF, double MontantHF )
        {
            bool vretour = true;
            try
            {

            }catch(Exception e)
            {
                vretour = false;
            }
            return vretour;
        }


        public static void ajouterUneDemande(fichefrais f)
        {
           
            LigneFraisForfait fraisNuit = f.LigneFraisForfait.ElementAt(0);
            LigneFraisForfait fraisMidi = f.LigneFraisForfait.ElementAt(1);
            LigneFraisForfait fraisVoiture = f.LigneFraisForfait.ElementAt(2);

            // Parcours les lignes horsForfaits

            foreach (LigneFraisHorsForfait l in f.LigneFraisHorsForfait)
            {
                
            }

            try
            {
                connexion.SaveChanges();
            }
            catch (Exception e)
            {

            }
            // Je veux recuperer la collection de fiches frais du visiteur
            visiteurConnnecte.fichefrais.Add(f);

            // REMPLIR L OBJET FRAISFORFAIT depuis ligneforfait, et specifier fiche de frais dans cette objet idem pour fraisforfait
            //$exception	{"Échec de la validation d'une ou de plusieurs entités. Pour plus d'informations, consultez 'EntityValidationErrors'."}	System.Data.Entity.Validation.DbEntityValidationException


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


        public static void modifierInformations(string nom, string prenom, string rue, string ville)
        {
            visiteurConnnecte.nom = nom;
            visiteurConnnecte.prenom = prenom;
            visiteurConnnecte.ville = ville;
            visiteurConnnecte.rue = rue;

            try
            {
                connexion.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                connexion.Dispose();
                init();
            }
        }

        public static bool modifierMDP(string mdp, string nouv)
        {
            if (GetMd5Hash(mdp).ToUpper() == visiteurConnnecte.password.TrimEnd(' '))
            {
                visiteurConnnecte.password = GetMd5Hash(nouv).ToUpper();
                Console.WriteLine(visiteurConnnecte.password);

                try
                {
                    connexion.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    connexion.Dispose();
                    init();
                }
                return true;
            }
            else return false;
        }
        


        /****************************/
        /*ACCES A LA BASE DE DONNEES*/
        /****************************/

        private static Visiteur VisiteurParSesId(string id, string mdp)
        {
            //Retourne le premier visiteur, s'il y en a plusieurs, qui comporte un couple id/password.
            return connexion.Visiteur.Where(x => (x.identifiant == id) && (x.password == mdp)).First();
        }




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
                        .Where(x => x.idStyle == 1)
                        .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.anNais, x.anMort, x.remarque })
                        .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList();
        }
        */


    }
}
