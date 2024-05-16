using ElifBlog.API.Data.Entity;

namespace ElifBlog.API.Data.Models
{
    public class BlogsOfAuthor
    {
        public string? AuthorName { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
