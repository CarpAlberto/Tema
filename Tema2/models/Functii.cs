namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Functii")]
    public partial class Functii
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Functie { get; set; }
    }
}
