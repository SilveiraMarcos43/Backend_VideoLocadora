using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SVL.Domain.Location;

namespace SVL.Infra.Mapping
{
    /// <summary>
    /// Implementa IEntityTypeConfiguration - Interface do Entity FrameCore do Fluent Api
    /// </summary>
    public class LocationMap : IEntityTypeConfiguration<LocationAggregate>
    {
        public void Configure(EntityTypeBuilder<LocationAggregate> builder)
        {
            builder
                .HasKey(s => s.ID);

            builder
                .Property(c => c.Value).HasColumnType("int")
                .IsRequired();

            builder
                .Property(c => c.Date).HasColumnType("date");

        }
    }
}