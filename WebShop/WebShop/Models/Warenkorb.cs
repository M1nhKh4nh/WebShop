namespace WebShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Warenkorb")]
    public partial class Warenkorb
    {
        public int Id { get; set; }

        public int FK_BenutzerId { get; set; }

        public int FK_ProduktId { get; set; }

        public virtual Benutzer Benutzer { get; set; }

        public virtual Produkt Produkt { get; set; }
    }
}
