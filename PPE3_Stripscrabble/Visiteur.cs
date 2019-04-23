//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_Stripscrabble
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visiteur
    {
        public Visiteur()
        {
            this.fichefrais = new HashSet<fichefrais>();
            this.RAPPORT = new HashSet<RAPPORT>();
            this.RegionResp = new HashSet<Region>();
            this.Secteur = new HashSet<Secteur>();
            this.Region = new HashSet<Region>();
            this.LaboResp = new HashSet<Laboratoire>();
        }
    
        public string idVisiteur { get; set; }
        public int idLabo { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string NomComplet { get { return prenom + " " + nom; } }
        public string rue { get; set; }
        public string cp { get; set; }
        public string ville { get; set; }
        public string dateEmbauche { get; set; }
        public string identifiant { get; set; }
        public string password { get; set; }
        public bool actif { get; set; }
    
        public virtual ICollection<fichefrais> fichefrais { get; set; }
        public virtual Laboratoire Laboratoire { get; set; }
        public virtual ICollection<RAPPORT> RAPPORT { get; set; }
        public virtual ICollection<Region> RegionResp { get; set; }
        public virtual ICollection<Secteur> Secteur { get; set; }
        public virtual ICollection<Region> Region { get; set; }
        public virtual ICollection<Laboratoire> LaboResp { get; set; }
    }
}
