using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SVL.Infra.Entities;

namespace SVL.Infra.Mapping
{
    /// <summary>
    /// Implementa IEntityTypeConfiguration - Interface do Entity FrameCore do Fluent Api
    /// </summary>
    public class MediaLocationMap : IEntityTypeConfiguration<MediaLocation>
    {
        public void Configure(EntityTypeBuilder<MediaLocation> builder)
        {
            builder
                .HasKey(s => s.ID);

            builder
                .Property(c => c.MediaID).HasColumnType("int")
                .IsRequired();

            builder
                .Property(c => c.LocationID).HasColumnType("int")
                .IsRequired();

        }
    }
}

