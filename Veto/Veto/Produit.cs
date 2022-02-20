//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit()
        {
            this.Medicament = new HashSet<Medicament>();
            this.ProduitFacture = new HashSet<ProduitFacture>();
            this.ProduitOrdonnance = new HashSet<ProduitOrdonnance>();
        }
    
        public int IdProduit { get; set; }
        public string NomProduit { get; set; }
        public int QuantiteEnStock { get; set; }
        public byte[] ImageProduit { get; set; }
        public double PrixVenteClient { get; set; }
        public double PrixAchat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicament> Medicament { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProduitFacture> ProduitFacture { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProduitOrdonnance> ProduitOrdonnance { get; set; }
    }
}
