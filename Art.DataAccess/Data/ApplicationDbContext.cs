//using ArtAndTechnicalEducationInstitute.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtAndTechnicalEducationInstitute.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet <StudentsRegister> Students { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<StudentsRegister>().HasData(
        //        new StudentsRegister { Id=1, Name="Action" }    
        //    );
        //}
    }
}
