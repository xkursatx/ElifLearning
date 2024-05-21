using ElifBlog.API.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace ElifBlog.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Author> AuthorTable { get; set; }
        public DbSet<Blog> BlogTable { get; set; }
    }
}
