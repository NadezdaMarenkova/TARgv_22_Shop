using Shop.Models;
using Microsoft.EntityFrameworkCore;
namespace Shop.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<LeadEntity> Leads { get; set; }
    }
}
