using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SimpleTaskSystem.EntityFrameworkCore
{
    public class SimpleTaskSystemDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public SimpleTaskSystemDbContext(DbContextOptions<SimpleTaskSystemDbContext> options) 
            : base(options)
        {

        }
    }
}
