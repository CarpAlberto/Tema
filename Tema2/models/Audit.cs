namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Audit")]
    public partial class Audit
    {
        public int ID { get; set; }

        public int Tip_Operatie { get; set; }

        [StringLength(50)]
        public string Data_Ora { get; set; }

        [StringLength(200)]
        public string Descriere { get; set; }
    }
}
