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
    
    public partial class FAMILLE
    {
        public FAMILLE()
        {
            this.MEDICAMENT = new HashSet<MEDICAMENT>();
        }
    
        public string idFamille { get; set; }
        public string libFamille { get; set; }
    
        public virtual ICollection<MEDICAMENT> MEDICAMENT { get; set; }
    }
}
