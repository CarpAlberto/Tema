namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Utilizatori")]
    public partial class Utilizatori
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Parola { get; set; }

        public int ID_Permisiune { get; set; }

        public bool Activ { get; set; }

        public virtual Permisiuni Permisiuni { get; set; }
    }
}
