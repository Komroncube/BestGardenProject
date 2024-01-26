using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BestGarden.Infrastructure.Configurations.Entities;
public class QuestionEntityConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.ToTable("Questions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Email)
            .HasMaxLength(100)
            .IsRequired(true);
        builder.Property(x=>x.Message)
            .HasMaxLength(1000)
            .IsRequired(true);
        builder.Property(x=>x.FullName)
            .HasMaxLength(50)
            .IsRequired(true);
        builder.Property(x => x.IsAnswered)
            .HasDefaultValue(false)
            .IsRequired();
    }

}
