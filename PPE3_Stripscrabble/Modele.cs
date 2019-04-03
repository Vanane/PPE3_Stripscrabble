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
        public static Visiteur visiteurConnecte;

        public static void init()
        {
            connexion = new PPE3_StripscrabbleEntities();
            visiteurConnecte = new Visiteur();
        }

        #region Getters/Setters
        //Liste des getters et setters de visiteurConnecté, mis en région pour masquer le bloc
        public static string getIdVisiteur() { return visiteurConnecte.idVisiteur; }
        public static int getIdLabo() { return visiteurConnecte.idLabo; }
        public static string getNom() { return visiteurConnecte.nom; }
        public static string getPrenom() { return visiteurConnecte.prenom; }
        public static string getRue() { return visiteurConnecte.rue; }
        public static string getCp() { return visiteurConnecte.cp; }
        public static string getVille() { return visiteurConnecte.ville; }
        public static string getDateEmbauche() { return visiteurConnecte.dateEmbauche; }
        public static string getIdentifiant() { return visiteurConnecte.identifiant; }
        public static string getPassword() { return visiteurConnecte.password; }

        public static void setIdVisiteur(string p) { visiteurConnecte.idVisiteur = p; }
        public static void setIdLabo(int p) { visiteurConnecte.idLabo = p; }
        public static void setNom(string p) { visiteurConnecte.nom = p; }
        public static void setPrenom(string p) { visiteurConnecte.prenom = p; }
        public static void setRue(string p) { visiteurConnecte.rue = p; }
        public static void setCp(string p) { visiteurConnecte.cp = p; }
        public static void setVille(string p) { visiteurConnecte.ville = p; }
        public static void setDateEmbauche(string p) { visiteurConnecte.dateEmbauche = p; }
        public static void setIdentifiant(string p) { visiteurConnecte.identifiant = p; }
        public static void setPassword(string p) { visiteurConnecte.password = p; }
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
                Modele.visiteurConnecte = VisiteurParSesId(id, mdpHash);
                r = true;
            }
            catch (Exception e)
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


        public static void modifierInformations(string nom, string prenom, string rue, string ville)
        {
            visiteurConnecte.nom = nom;
            visiteurConnecte.prenom = prenom;
            visiteurConnecte.ville = ville;
            visiteurConnecte.rue = rue;

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
            if (GetMd5Hash(mdp).ToUpper() == visiteurConnecte.password.TrimEnd(' '))
            {
                visiteurConnecte.password = GetMd5Hash(nouv).ToUpper();

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



        public static void Save()
        {
            connexion.SaveChanges();
        }


        /****************************/
        /*ACCES A LA BASE DE DONNEES*/
        /****************************/


        public static Visiteur VisiteurParSonId(string id)
        {
            return connexion.Visiteur.Where(x => x.idVisiteur == id).First();


        }
        public static Visiteur VisiteurParSesId(string id, string mdp)
        {
            //Retourne le premier visiteur, s'il y en a plusieurs, qui comporte un couple id/password.
            return connexion.Visiteur.Where(x => (x.identifiant == id) && (x.password == mdp)).First();
        }

        public static List<Visiteur> VisiteursParSecteur(int idS)
        {
            List<Visiteur> r = new List<Visiteur>();
            foreach (Region re in connexion.Secteur.Where(x => x.idSecteur == idS).First().Region )
            {
                foreach (Visiteur v in re.Visiteurs.ToList())
                {
                    r.Add(v);
                }
            }
            return r;
        }

        public static List<Visiteur> VisiteursParRegion(int idR)
        {
            List<Visiteur> r = new List<Visiteur>();
            Region re = connexion.Region.Where(x=>x.idRegion == idR).First();
                foreach (Visiteur v in re.Visiteurs.ToList())
                {
                    r.Add(v);
                }
            return r;
        }

        public static Region RegionParSonId(int id)
        {
            return connexion.Region.Where(x => x.idRegion == id).First();
        }

        public static List<Secteur> lesSecteurs()
        {
            return connexion.Secteur.ToList();
        }

        public static List<Region> lesRegions()
        {
            return connexion.Region.ToList();
        }

        public static List<Visiteur> LesVisiteurs()
        {
            return connexion.Visiteur.ToList();

        }


        public static List<Region> RegionsParSecteur(Secteur s)
        {
            List<Region> retour = connexion.Region.Where(x => x.idSecteur == s.idSecteur).ToList();


            return retour;
        }

        public static Visiteur ResponsableParSecteur(int idS)
        {
            return connexion.Secteur.Where(x => x.idSecteur == idS).First().Visiteur;
        }

        public static Visiteur ResponsableParRegion(int idR)
        {
            return connexion.Region.Where(x => x.idRegion == idR).First().VisiteurResp;            
        }


        public static bool[] EstResponsable()
        {
            //Renvoie un tableau de bool permettant de savoir si l'utilisateur connecté
            //Est responsable d'un laboratoire, d'une région, d'un secteur.

            bool[] r = new bool[3];

            //r[numCase] = "Le nombre de lignes renvoyées par la requête est > 0."
            //Si oui, alors le visiteur est responsable d'au moins un élément.
            r[0] = connexion.Laboratoire.Where(x => x.idDirecteur == visiteurConnecte.idVisiteur).Count() > 0;
            r[1] = connexion.Region.Where(x => x.idVisiteur == visiteurConnecte.idVisiteur).Count() > 0;
            r[2] = connexion.Secteur.Where(x => x.idVisiteur == visiteurConnecte.idVisiteur).Count() > 0;
            return r;        
        }


        public static string ChangeRespRegion(Region r, Visiteur v)
        {
            try
            {
                r.idVisiteur = v.idVisiteur;
                connexion.SaveChanges();
                return "Mise à jour effectuée !";
            }
            catch (Exception e)
            {
                return "Erreur lors de l'insertion, réessayez ultérieurement.";
            }
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
                        .Where(x => x.idStyle == idStyle)
                        .Select(x => new { x.nomCompositeur, x.prenomCompositeur, x.anNais, x.anMort, x.remarque })
                        .OrderBy(x => x.nomCompositeur);
            return LQuery.ToList();
        }
        */


    }
}
