using Microsoft.EntityFrameworkCore;
using proj.Models;

namespace proj.Data
{
    public class ProjContext : DbContext
    {
        public ProjContext(DbContextOptions<ProjContext> opt) : base(opt)
        {
            
        }
        public DbSet<Detail> Details { get; set; }
    }
}