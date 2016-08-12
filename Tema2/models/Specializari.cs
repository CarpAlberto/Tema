namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Specializari")]
    public partial class Specializari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specializari()
        {
            Grupes = new HashSet<Grupe>();
            Specializari_Materii = new HashSet<Specializari_Materii>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nume { get; set; }

        public int ID_Facultate { get; set; }

        public virtual Facultati Facultati { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grupe> Grupes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specializari_Materii> Specializari_Materii { get; set; }
    }
}
