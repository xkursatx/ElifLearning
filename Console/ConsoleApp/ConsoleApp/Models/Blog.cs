using System.Xml.Linq;

namespace ConsoleApp.Models
{
    public class Blog : BaseAuditable
    {
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public void WriteToConsole()
        {
            Console.WriteLine($"{Title} {AuthorId} {CreatedDate}/{ModifiedDate}");
        }

    }
}
