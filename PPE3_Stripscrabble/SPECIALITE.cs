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
    
    public partial class SPECIALITE
    {
        public SPECIALITE()
        {
            this.MEDECIN = new HashSet<MEDECIN>();
        }
    
        public string idSpecialite { get; set; }
        public string libSpecialite { get; set; }
    
        public virtual ICollection<MEDECIN> MEDECIN { get; set; }
    }
}
