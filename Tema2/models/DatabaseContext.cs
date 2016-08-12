namespace Tema2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<Facultati> Facultatis { get; set; }
        public virtual DbSet<Functii> Functiis { get; set; }
        public virtual DbSet<Grupe> Grupes { get; set; }
        public virtual DbSet<Indrumatori> Indrumatoris { get; set; }
        public virtual DbSet<Materie> Materies { get; set; }
        public virtual DbSet<Permisiuni> Permisiunis { get; set; }
        public virtual DbSet<Profesori> Profesoris { get; set; }
        public virtual DbSet<Promotii> Promotiis { get; set; }
        public virtual DbSet<Specializari> Specializaris { get; set; }
        public virtual DbSet<Specializari_Materii> Specializari_Materii { get; set; }
        public virtual DbSet<Studenti> Studentis { get; set; }
        public virtual DbSet<Studenti_Absente> Studenti_Absente { get; set; }
        public virtual DbSet<Studenti_Note> Studenti_Note { get; set; }
        public virtual DbSet<Utilizatori> Utilizatoris { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facultati>()
                .Property(e => e.Descriere)
                .IsFixedLength();

            modelBuilder.Entity<Facultati>()
                .HasMany(e => e.Specializaris)
                .WithRequired(e => e.Facultati)
                .HasForeignKey(e => e.ID_Facultate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Grupe>()
                .HasMany(e => e.Indrumatoris)
                .WithOptional(e => e.Grupe)
                .HasForeignKey(e => e.ID_Grupa);

            modelBuilder.Entity<Grupe>()
                .HasMany(e => e.Studentis)
                .WithRequired(e => e.Grupe)
                .HasForeignKey(e => e.ID_Grupa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materie>()
                .Property(e => e.Nume)
                .IsFixedLength();

            modelBuilder.Entity<Materie>()
                .HasMany(e => e.Specializari_Materii)
                .WithRequired(e => e.Materie)
                .HasForeignKey(e => e.ID_Materie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materie>()
                .HasMany(e => e.Studenti_Absente)
                .WithRequired(e => e.Materie)
                .HasForeignKey(e => e.ID_Materie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Materie>()
                .HasMany(e => e.Studenti_Note)
                .WithRequired(e => e.Materie)
                .HasForeignKey(e => e.ID_Materie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permisiuni>()
                .HasMany(e => e.Utilizatoris)
                .WithRequired(e => e.Permisiuni)
                .HasForeignKey(e => e.ID_Permisiune)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesori>()
                .Property(e => e.Numar_Telefon)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Profesori>()
                .HasMany(e => e.Indrumatoris)
                .WithRequired(e => e.Profesori)
                .HasForeignKey(e => e.ID_Profesor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesori>()
                .HasMany(e => e.Specializari_Materii)
                .WithRequired(e => e.Profesori)
                .HasForeignKey(e => e.ID_Profesor_Titular)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Profesori>()
                .HasMany(e => e.Specializari_Materii1)
                .WithOptional(e => e.Profesori1)
                .HasForeignKey(e => e.ID_Profesor_Laborant);

            modelBuilder.Entity<Promotii>()
                .HasMany(e => e.Grupes)
                .WithRequired(e => e.Promotii)
                .HasForeignKey(e => e.ID_Promotie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Promotii>()
                .HasMany(e => e.Indrumatoris)
                .WithRequired(e => e.Promotii)
                .HasForeignKey(e => e.ID_Promotie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specializari>()
                .HasMany(e => e.Grupes)
                .WithRequired(e => e.Specializari)
                .HasForeignKey(e => e.ID_Specializare)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Specializari>()
                .HasMany(e => e.Specializari_Materii)
                .WithRequired(e => e.Specializari)
                .HasForeignKey(e => e.ID_Specializare)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Studenti>()
                .HasMany(e => e.Studenti_Absente)
                .WithRequired(e => e.Studenti)
                .HasForeignKey(e => e.ID_Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Studenti>()
                .HasMany(e => e.Studenti_Note)
                .WithRequired(e => e.Studenti)
                .HasForeignKey(e => e.ID_Student)
                .WillCascadeOnDelete(false);
        }
    }
}
