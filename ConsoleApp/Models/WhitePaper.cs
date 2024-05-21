namespace ConsoleApp.Models
{
    public class WhitePaper : BaseAuditable
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
