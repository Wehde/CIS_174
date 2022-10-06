using Microsoft.EntityFrameworkCore;

namespace Week6.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
            new Student
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Grade = "A-"
            },
            new Student
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Grade = "A"
            },
            new Student
            {
                Id = 3,
                FirstName = "Joe",
                LastName = "Schmoe",
                Grade = "C+"
            },
            new Student
            {
                Id = 4,
                FirstName = "Blue",
                LastName = "Falcon",
                Grade = "F"
            }
            );
        }
    }
}
