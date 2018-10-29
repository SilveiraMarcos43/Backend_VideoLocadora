using Microsoft.EntityFrameworkCore;
using SVL.Domain.Base;
using SVL.Domain.Devolution;
using SVL.Domain.Location;
using SVL.Infra.DomainConfig;

namespace SVL.Infra.Data
{
    public class BaseContexto : DbContext
    {
        public BaseContexto(DbContextOptions<BaseContexto> options) : base(options)
        {

        }

        public DbSet<Address> addresses { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<LocationMedia> locations { get; set; }
        public DbSet<Devolution> devolutions { get; set; }
        public DbSet<Contato> contatos { get; set; }
        public DbSet<Media> medias { get; set; }
        public DbSet<Wallet> credits { get; set; }
        public DbSet<MediaLocation> mediaLocations { get; set; }


        /// <summary>
        /// Configuração do Contexto da Aplicação
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationMedia>().ToTable("Location");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Devolution>().ToTable("Devolution");
            modelBuilder.Entity<Media>().ToTable("Media");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Wallet>().ToTable("Credit");
            modelBuilder.Entity<Address>().ToTable("Address");

            /* Classe que contém as configurações do Customer */
            modelBuilder.ApplyConfiguration(new CustomerMap());
                                           
        }
    }
}
