namespace Tema2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Materie")]
    public partial class Materie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materie()
        {
            Specializari_Materii = new HashSet<Specializari_Materii>();
            Studenti_Absente = new HashSet<Studenti_Absente>();
            Studenti_Note = new HashSet<Studenti_Note>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nume { get; set; }

        [StringLength(50)]
        public string Descriere { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specializari_Materii> Specializari_Materii { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Studenti_Absente> Studenti_Absente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Studenti_Note> Studenti_Note { get; set; }
    }
}
