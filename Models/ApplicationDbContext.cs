using Microsoft.EntityFrameworkCore;

namespace YetAnotheToDoList.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {

        }
       public DbSet<MyTask> MyTasks { get; set; }
    }
}
