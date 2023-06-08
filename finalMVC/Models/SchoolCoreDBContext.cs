using Microsoft.EntityFrameworkCore;

namespace finalMVC.Models
{
    public partial class SchoolCoreDBContext : DbContext
    {
        const string connectionString = "Server=localhost; User ID=root; Password=; Database=school";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Apprenant>().ToTable("Apprenant");
            modelBuilder.Entity<Filiere>().ToTable("Filiere");
            modelBuilder.Entity<Matiere>().ToTable("Matiere");
            modelBuilder.Entity<Preinscription>().ToTable("Preinscription");
            modelBuilder.Entity<Section>().ToTable("Section");
            modelBuilder.Entity<Visiteur>().ToTable("Visiteur");
            modelBuilder.Entity<Formation>().ToTable("Formation");
            modelBuilder.Entity<User>(entity => {
                entity.HasKey(k => k.ID);
            });


            modelBuilder.Entity<Formation>().HasKey(b => b.ID).HasName("PK_Formation");

            //new BookMap(modelBuilder.Entity<Book>());
        }
        public SchoolCoreDBContext(DbContextOptions options) : base(options)
        {
        }

        protected SchoolCoreDBContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<User> UserLogin { get; set; }
    }
}
