using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleTaskSystem.People;
using SimpleTaskSystem.Tasks;

namespace SimpleTaskSystem.EntityFrameworkCore
{
    public class SimpleTaskSystemDbContext : AbpDbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public SimpleTaskSystemDbContext(DbContextOptions<SimpleTaskSystemDbContext> options)
            : base(options)
        {

        }
    }
}
