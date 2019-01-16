namespace WebShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Benutzer")]
    public partial class Benutzer
    {
        public int BenutzerId { get; set; }

        public string Benutzername { get; set; }

        public string Passwort { get; set; }
    }
}
