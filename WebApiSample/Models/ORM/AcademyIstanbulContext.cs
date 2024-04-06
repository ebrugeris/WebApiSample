using Microsoft.EntityFrameworkCore;

namespace WebApiSample.Models.ORM
{
    public class AcademyIstanbulContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ISTANBUL13\\SQLEXPRESS;Database=AcademyIstanbul;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<University> Universities { get; set; }

    }
}
