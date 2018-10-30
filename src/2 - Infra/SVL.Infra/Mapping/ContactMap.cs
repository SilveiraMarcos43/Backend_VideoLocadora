using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SVL.Domain.Base;

namespace SVL.Infra.Mapping
{
    /// <summary>
    /// Implementa IEntityTypeConfiguration - Interface do Entity FrameCore do Fluent Api
    /// </summary>
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder
                .HasKey(s => s.ID);

            builder
                .Property(c => c.Name).HasColumnType("varchar(100)")
                .IsRequired();

        }
    }
}