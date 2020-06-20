using Microsoft.EntityFrameworkCore;
using MVCTestApplication.Models;

namespace MVCTestApplication.Data
{
    public class TodoDBContext:DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options) :base(options)
        {            
        }
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder )
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
