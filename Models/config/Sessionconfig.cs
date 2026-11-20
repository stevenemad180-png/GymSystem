using gym.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gym.Models.config
{
    public class Sessionconfig : IEntityTypeConfiguration<Session>
    {
        public  void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreatedAt)

                .HasDefaultValueSql("GETDATE()");

            builder.HasOne(x => x.trainer)
                .WithMany(x => x.Sessions)
                .HasForeignKey(x => x.trainerId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.ToTable(x =>
            {
                x.HasCheckConstraint(
                    "CK_Sessions_Capacity",
                    "[capacity] BETWEEN 1 AND 25"
                );

                x.HasCheckConstraint(
                    "CK_Sessions_Time",
                    "[EndTime] > [StartTime]"
                );
            });








        }
    }
}
