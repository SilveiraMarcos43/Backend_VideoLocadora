using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SVL.Domain.Base;
using SVL.Domain.Devolution;
using SVL.Domain.Location;
using SVL.Infra.DomainConfig;
using SVL.Infra.Entities;
using SVL.Infra.Mapping;
using SVL.Infra.Repository;
using Media = SVL.Domain.Base.Media;

namespace SVL.Infra.Data
{
    public class BaseContext : DbContext, IDbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        public BaseContext()
        {

        }

        public DbSet<Address> addresses { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Domain.Location.LocationAggregate> locations { get; set; }
        public DbSet<Devolution> devolutions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Media> medias { get; set; }
        public DbSet<Wallet> wallet { get; set; }

        public DbSet<T> DbSet<T>() where T : class
        {
            return DbSet<T>();
        }

        public void Rollback()
        {
            ChangeTracker.Entries().ToList().ForEach(x =>
            {
                x.State = EntityState.Detached;
                var keys = GetEntityKey(x.Entity);
                DbSet(x.Entity.GetType(), keys);
            });
        }

        public object[] GetEntityKey<T>(T entity) where T : class
        {
            var state = Entry(entity);
            var metadata = state.Metadata;
            var key = metadata.FindPrimaryKey();
            var props = key.Properties.ToArray();
            return props.Select(x => x.GetGetter().GetClrValue(entity)).ToArray();
        }

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
            modelBuilder.Entity<Wallet>().ToTable("Wallet");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<MediaLocation>().ToTable("MediaLocation");

            /* Classe que contém as configurações do Customer */
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new MediaMap());
            modelBuilder.ApplyConfiguration(new LocationMap());
            modelBuilder.ApplyConfiguration(new DevolutionMap());
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new WalletMap());
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new MediaLocationMap());



        }

        IQueryable<T> IDbContext.Set<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}
