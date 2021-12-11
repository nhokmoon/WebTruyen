using Microsoft.EntityFrameworkCore;

namespace WebTruyen.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Truyen> Truyens { get; set; }
    }
}
