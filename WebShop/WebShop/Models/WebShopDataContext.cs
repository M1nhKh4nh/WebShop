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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
