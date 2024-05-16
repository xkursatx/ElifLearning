using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ElifBlog.API.Data.Entity
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? ImageUrl { get; set; }
    }
}
