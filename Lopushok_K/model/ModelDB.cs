using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lopushok_K.model
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Manager_for_agent> Manager_for_agent { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Production> Production { get; set; }
        public virtual DbSet<Quality_control> Quality_control { get; set; }
        public virtual DbSet<Release_history> Release_history { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Workshop> Workshop { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>()
                .HasMany(e => e.Manager_for_agent)
                .WithRequired(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.Release_history)
                .WithRequired(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manager>()
                .HasMany(e => e.Manager_for_agent)
                .WithRequired(e => e.Manager)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materials>()
                .Property(e => e.Material_type)
                .IsUnicode(false);

            modelBuilder.Entity<Materials>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Materials>()
                .HasMany(e => e.Production)
                .WithRequired(e => e.Materials)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materials>()
                .HasMany(e => e.Quality_control)
                .WithRequired(e => e.Materials)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Production)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shop>()
                .HasMany(e => e.Release_history)
                .WithRequired(e => e.Shop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shop>()
                .HasMany(e => e.Workshop)
                .WithRequired(e => e.Shop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Workshop>()
                .HasMany(e => e.Production)
                .WithRequired(e => e.Workshop)
                .WillCascadeOnDelete(false);
        }
    }
}
