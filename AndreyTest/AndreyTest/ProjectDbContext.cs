using AndreyTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AndreyTest
{
    public sealed class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Project> Projects { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}