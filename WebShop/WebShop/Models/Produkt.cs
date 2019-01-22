namespace WebShop.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produkt")]
    public partial class Produkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkt()
        {
            Warenkorbs = new HashSet<Warenkorb>();
        }

        public int ProduktId { get; set; }

        public string Produktname { get; set; }

        public string Produktbeschreibung { get; set; }

        public int? Preis { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warenkorb> Warenkorbs { get; set; }
    }
}
