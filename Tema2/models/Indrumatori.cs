namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Indrumatori")]
    public partial class Indrumatori
    {
        public int ID { get; set; }

        public int ID_Profesor { get; set; }

        public int? ID_Grupa { get; set; }

        public int ID_Promotie { get; set; }

        public virtual Grupe Grupe { get; set; }

        public virtual Profesori Profesori { get; set; }

        public virtual Promotii Promotii { get; set; }
    }
}
