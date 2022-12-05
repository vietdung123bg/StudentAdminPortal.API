using Microsoft.EntityFrameworkCore;

namespace Portal.API.DataModels
{
    public class StudentAdminContext: DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options): base(options)
        {

        }

        // Student Table
        public DbSet<Student> Student { get; set; }

        // Gender Table
        public DbSet<Gender> Gender { get; set; }

        // Address Table
        public DbSet<Address> Address { get; set; }
    }
}
