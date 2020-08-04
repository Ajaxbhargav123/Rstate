using Microsoft.EntityFrameworkCore;
using RstateAPI.Entities;

namespace RstateAPI.Data
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options):base(options)
        {
        }
        public DbSet<TestData> test{get;set;}
    }
}