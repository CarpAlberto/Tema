namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Permisiuni")]
    public partial class Permisiuni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permisiuni()
        {
            Utilizatoris = new HashSet<Utilizatori>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Permisiune { get; set; }

        [StringLength(200)]
        public string Descriere { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilizatori> Utilizatoris { get; set; }
    }
}
