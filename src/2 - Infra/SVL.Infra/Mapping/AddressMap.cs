using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SVL.Domain.Base;

namespace SVL.Infra.Mapping
{
    /// <summary>
    /// Implementa IEntityTypeConfiguration - Interface do Entity FrameCore do Fluent Api
    /// </summary>
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .HasKey(s => s.ID);

            builder
                .Property(c => c.City).HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(c => c.District).HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(c => c.State).HasColumnType("varchar(2)")
                .IsRequired();

            builder
                .Property(c => c.StreetDescription).HasColumnType("varchar(150)")
                .IsRequired();

            builder
                .Property(c => c.Cep).HasColumnType("varchar(10)")
                .IsRequired();

        }
    }
}