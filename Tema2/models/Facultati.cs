namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Facultati")]
    public partial class Facultati
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facultati()
        {
            Specializaris = new HashSet<Specializari>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nume { get; set; }

        [StringLength(500)]
        public string Descriere { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specializari> Specializaris { get; set; }
    }
}
