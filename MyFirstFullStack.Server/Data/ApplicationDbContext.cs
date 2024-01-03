using Microsoft.EntityFrameworkCore;
using MyFirstFullStack.Server.Models;

namespace MyFirstFullStack.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
