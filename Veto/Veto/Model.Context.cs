﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<AnimalRDV> AnimalRDV { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Facture> Facture { get; set; }
        public virtual DbSet<HoraireTravail> HoraireTravail { get; set; }
        public virtual DbSet<Journee> Journee { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Maladie> Maladie { get; set; }
        public virtual DbSet<MaladieAnimal> MaladieAnimal { get; set; }
        public virtual DbSet<Medicament> Medicament { get; set; }
        public virtual DbSet<Ordonnance> Ordonnance { get; set; }
        public virtual DbSet<Produit> Produit { get; set; }
        public virtual DbSet<ProduitFacture> ProduitFacture { get; set; }
        public virtual DbSet<ProduitOrdonnance> ProduitOrdonnance { get; set; }
        public virtual DbSet<RendezVous> RendezVous { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Salarie> Salarie { get; set; }
        public virtual DbSet<Soins> Soins { get; set; }
        public virtual DbSet<SoinsMaladie> SoinsMaladie { get; set; }
    }
}