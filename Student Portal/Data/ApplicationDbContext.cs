using Microsoft.EntityFrameworkCore;
using Student_Portal.Models.Entities;

namespace Student_Portal.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
