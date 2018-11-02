using BusinessLogic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SVL.Infra.Repository;

namespace DataAccess
{
    public class LocationContext : DbContext, IDbContext
    {
        private readonly string _connectionString;

        public LocationContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        public void Rollback()
        {
            ChangeTracker.Entries().ToList().ForEach(x =>
            {
                x.State = EntityState.Detached;
                var keys = GetEntityKey(x.Entity);
                Set(x.Entity.GetType(), keys);
            });
        }

        public DbSet<T> Set<T>() where T : class
        {
            return Set<T>();
        }

        public object[] GetEntityKey<T>(T entity) where T : class
        {
            var state = Entry(entity);
            var metadata = state.Metadata;
            var key = metadata.FindPrimaryKey();
            var props = key.Properties.ToArray();
            return props.Select(x => x.GetGetter().GetClrValue(entity)).ToArray();
        }
    }
}