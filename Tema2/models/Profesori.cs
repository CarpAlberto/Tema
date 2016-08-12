namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Profesori")]
    public partial class Profesori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Profesori()
        {
            Indrumatoris = new HashSet<Indrumatori>();
            Specializari_Materii = new HashSet<Specializari_Materii>();
            Specializari_Materii1 = new HashSet<Specializari_Materii>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nume { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Numar_Telefon { get; set; }

        [StringLength(50)]
        public string Locatie { get; set; }

        public int? ID_Functie { get; set; }

        [StringLength(500)]
        public string CV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indrumatori> Indrumatoris { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specializari_Materii> Specializari_Materii { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specializari_Materii> Specializari_Materii1 { get; set; }
    }
}
