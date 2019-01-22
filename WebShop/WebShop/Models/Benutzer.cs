namespace WebShop.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Benutzer")]
    public partial class Benutzer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Benutzer()
        {
            Warenkorbs = new HashSet<Warenkorb>();
        }

        public int BenutzerId { get; set; }

        public string Benutzername { get; set; }

        public string Passwort { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Warenkorb> Warenkorbs { get; set; }
    }
}
