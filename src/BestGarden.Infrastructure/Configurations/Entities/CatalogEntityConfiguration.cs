using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BestGarden.Infrastructure.Configurations.Entities;

internal class CatalogEntityConfiguration : IEntityTypeConfiguration<Catalog>
{
    public void Configure(EntityTypeBuilder<Catalog> builder)
    {
        builder.ToTable("Catalogs");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(x => x.PlantSystem)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasMany(x => x.Products)
            .WithOne(x => x.Catalog)
            .HasForeignKey(x => x.CatalogId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}