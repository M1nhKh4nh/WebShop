namespace WebShop.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WebShopDataContext : DbContext
    {
        public WebShopDataContext()
            : base("name=WebShopDataContext")
        {
        }

        public virtual DbSet<Benutzer> Benutzers { get; set; }
        public virtual DbSet<Produkt> Produkts { get; set; }
        public virtual DbSet<Warenkorb> Warenkorbs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Benutzer>()
                .HasMany(e => e.Warenkorbs)
                .WithRequired(e => e.Benutzer)
                .HasForeignKey(e => e.FK_BenutzerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produkt>()
                .HasMany(e => e.Warenkorbs)
                .WithRequired(e => e.Produkt)
                .HasForeignKey(e => e.FK_ProduktId)
                .WillCascadeOnDelete(false);
        }
    }
}
