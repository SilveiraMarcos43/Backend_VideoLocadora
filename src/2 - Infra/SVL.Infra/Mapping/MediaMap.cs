using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SVL.Domain.Base;

namespace SVL.Infra.Mapping
{
    /// <summary>
    /// Implementa IEntityTypeConfiguration - Interface do Entity FrameCore do Fluent Api
    /// </summary>
    public class MediaMap : IEntityTypeConfiguration<Media>
    {
        public void Configure(EntityTypeBuilder<Media> builder)
        {
            builder
                .HasKey(s => s.ID);

            builder
                .Property(c => c.Title).HasColumnType("varchar(100)")
                .IsRequired();

        }
    }
}
