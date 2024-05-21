using System.ComponentModel.DataAnnotations;

namespace ElifBlog.API.Data.Entity
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
