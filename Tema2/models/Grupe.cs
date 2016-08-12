namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Grupe")]
    public partial class Grupe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grupe()
        {
            Indrumatoris = new HashSet<Indrumatori>();
            Studentis = new HashSet<Studenti>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Nume { get; set; }

        public int ID_Specializare { get; set; }

        public int ID_Promotie { get; set; }

        public virtual Promotii Promotii { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indrumatori> Indrumatoris { get; set; }

        public virtual Specializari Specializari { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Studenti> Studentis { get; set; }
    }
}
