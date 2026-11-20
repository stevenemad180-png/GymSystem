using gym.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gym.Models.config
{
    public class planconfig : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreatedAt)

                .HasDefaultValueSql("GETDATE()");


            builder.ToTable(x =>
            {
                x.HasCheckConstraint(
                    "CK_Plans_DurationDays",
                    "[DurationDays] BETWEEN 1 AND 365"
                );
            });







        }
    }
}
    
