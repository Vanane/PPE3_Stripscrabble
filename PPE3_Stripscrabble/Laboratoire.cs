//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_Stripscrabble
{
    using System;
    using System.Collections.Generic;
    
    public partial class Laboratoire
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Laboratoire()
        {
            this.Visiteurs = new HashSet<Visiteur>();
        }
    
        public int idLabo { get; set; }
        public string nomLabo { get; set; }
        public string idDirecteur { get; set; }
    
        public virtual Visiteur Directeur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visiteur> Visiteurs { get; set; }
    }
}
