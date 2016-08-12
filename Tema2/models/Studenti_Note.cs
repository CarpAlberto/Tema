namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Studenti_Note
    {
        public int ID { get; set; }

        public int ID_Student { get; set; }

        public int ID_Materie { get; set; }

        public double Nota { get; set; }

        public virtual Materie Materie { get; set; }

        public virtual Studenti Studenti { get; set; }
    }
}
