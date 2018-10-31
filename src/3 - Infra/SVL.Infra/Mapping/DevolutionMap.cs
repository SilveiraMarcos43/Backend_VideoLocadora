using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SVL.Domain.Devolution;
using SVL.Domain.Location;

namespace SVL.Infra.Mapping
{
    /// <summary>
    /// Implementa IEntityTypeConfiguration - Interface do Entity FrameCore do Fluent Api
    /// </summary>
    public class DevolutionMap : IEntityTypeConfiguration<Devolution>
    {
        public void Configure(EntityTypeBuilder<Devolution> builder)
        {
            builder
                .HasKey(s => s.ID);
        }
    }
}