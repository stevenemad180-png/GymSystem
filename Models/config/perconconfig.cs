using gym.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace gym.Models.config
{
    public class perconconfig<T> : IEntityTypeConfiguration<T> where T : person

    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("Varchar")
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .HasColumnType("Varchar")
                .HasMaxLength(100);
            builder.ComplexProperty(x => x.Address);
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.HasIndex(x => x.Email).IsUnique();

            builder.ToTable(x =>
            {
                x.HasCheckConstraint("valid email", "Email Like'_%@%.com'");
                x.HasCheckConstraint("valid phone", "Len(phone)=11 And phone Like'010%' or phone Like'011%'or phone Like'012%' or phone Like'015%' ");

            }

            );




        }
    }
}
