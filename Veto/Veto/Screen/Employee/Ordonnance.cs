//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veto.Screen.Employee
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ordonnance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ordonnance()
        {
            this.ProduitOrdonnance = new HashSet<ProduitOrdonnance>();
        }
    
        public int idOrdonnance { get; set; }
        public Nullable<int> IdRdv { get; set; }
        public int IdAnimal { get; set; }
    
        public virtual Animal Animal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProduitOrdonnance> ProduitOrdonnance { get; set; }
        public virtual RendezVous RendezVous { get; set; }
    }
}
