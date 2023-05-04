using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Poslasticarnica.Configuration;

namespace Poslasticarnica.Model
{
    public class ApplicationContext : DbContext
    {
        private static ProjectConfiguration _configuration;

        public ApplicationContext(DbContextOptions<ApplicationContext> options, ProjectConfiguration configuration)
        {
            if (configuration == null)
            {
                _configuration = configuration;
            }
        }
        public ApplicationContext()
        {

        }
        public override int SaveChanges()
        {

            return base.SaveChanges();
        }

        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<KategorijaProizvoda> KategorijaProizvoda { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<KorisnikController> Porudzbina { get; set; }
        public DbSet<StavkaPorudzbineController> StavkaPorudzbine { get; set; }

        public DbSet<Sastojak> Sastojak { get; set; }
        public DbSet<SastojakProizvoda> SastojakProizvoda { get; set; }
        public DbSet<Isporuka> Isporuka { get; set; }
        public DbSet<Placanje> Placanje { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(optionBuilder.IsConfigured)
            {
                return;
            }

            optionBuilder.UseSqlServer("Server=LAPTOP-S8BLMRE6\\SQLEXPRESS;Database=PoslasticarnicaERP2;Trusted_Connection=True;");
        }
    }
}
