
using Microsoft.EntityFrameworkCore;

namespace ToDoListRefactored.Models
{
    public class ToDoListContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }


        public ToDoListContext(DbContextOptions options) : base(options) { }
    }
}
