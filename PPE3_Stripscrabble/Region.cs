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
    
    public partial class Region
    {
        public Region()
        {
            this.Visiteurs = new HashSet<Visiteur>();
        }
    
        public int idRegion { get; set; }
        public string libRegion { get; set; }
        public string idVisiteur { get; set; }
        public int idSecteur { get; set; }
    
        public virtual Secteur Secteur { get; set; }
        public virtual Visiteur VisiteurResp { get; set; }
        public virtual ICollection<Visiteur> Visiteurs { get; set; }
    }
}
