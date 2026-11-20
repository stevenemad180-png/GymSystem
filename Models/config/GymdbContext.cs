using gym.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace gym.Models.config
{
    public class GymdbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                            @"Server=.\SQLEXPRESS;Database=GymSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        
    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Plan> plans { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<MemberPlan> memberPlans { get; set; }
        public DbSet<Session> sessions { get; set; }
        public DbSet<trainer> trainers { get; set; }



    }
}
