namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specializari_Materii
    {
        public int ID { get; set; }

        public int ID_Materie { get; set; }

        public int ID_Specializare { get; set; }

        public int ID_Profesor_Titular { get; set; }

        public int? ID_Profesor_Laborant { get; set; }

        public virtual Materie Materie { get; set; }

        public virtual Profesori Profesori { get; set; }

        public virtual Profesori Profesori1 { get; set; }

        public virtual Specializari Specializari { get; set; }
    }
}
