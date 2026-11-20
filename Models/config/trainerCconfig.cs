using gym.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gym.Models.config
{
    public class trainerCconfig : perconconfig<trainer>, IEntityTypeConfiguration<trainer>
    {
        public new void Configure(EntityTypeBuilder<trainer> builder)
        {
            builder.Property(x => x.CreatedAt)
                .HasColumnName("HireDate")
                .HasDefaultValueSql("GETDATE()");


            base.Configure(builder);
        }
    }
}
