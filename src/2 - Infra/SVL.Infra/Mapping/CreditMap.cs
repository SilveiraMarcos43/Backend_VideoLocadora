using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SVL.Domain.Devolution;
using SVL.Domain.Location;

namespace SVL.Infra.Mapping
{
    /// <summary>
    /// Implementa IEntityTypeConfiguration - Interface do Entity FrameCore do Fluent Api
    /// </summary>
    public class CreditMap : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder
                .HasKey(s => s.ID);

            builder
                .Property(c => c.CreditPoints).HasColumnType("int")
                .IsRequired();

        }
    }
}