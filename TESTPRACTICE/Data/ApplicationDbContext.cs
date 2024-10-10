using TESTPRACTICE.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyTest
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }

        public DbSet<STUDENT> STUDENT { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<LOGREG> LOGREG { get; set; }

    }
}
