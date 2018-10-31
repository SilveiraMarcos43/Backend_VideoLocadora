using Microsoft.EntityFrameworkCore;
using SVL.Domain.Base;
using SVL.Domain.Devolution;
using SVL.Domain.Location;
using SVL.Infra.DomainConfig;
using SVL.Infra.Entities;
using SVL.Infra.Mapping;
using Media = SVL.Domain.Base.Media;

namespace SVL.Infra.Data
{
    public class BaseContexto : DbContext
    {
        public BaseContexto(DbContextOptions<BaseContexto> options) : base(options)
        {

        }

        public DbSet<Address> addresses { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Domain.Location.LocationAggregate> locations { get; set; }
        public DbSet<Devolution> devolutions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Media> medias { get; set; }
        public DbSet<Wallet> credits { get; set; }

        /// <summary>
        /// Configuração do Contexto da Aplicação
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationAggregate>().ToTable("Location");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Devolution>().ToTable("Devolution");
            modelBuilder.Entity<Media>().ToTable("Media");
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<Wallet>().ToTable("Credit");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<MediaLocation>().ToTable("MediaLocation");

            /* Classe que contém as configurações do Customer */
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new MediaMap());
            modelBuilder.ApplyConfiguration(new LocationMap());
            modelBuilder.ApplyConfiguration(new DevolutionMap());
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new CreditMap());
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new MediaLocationMap());



        }
    }
}
