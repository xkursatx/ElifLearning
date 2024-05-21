using ConsoleApp.Models;

List<Author> authors = new();

authors.Add(new Author { Id = 1, Name = "Berk", Surname = "İpekoğlu" });
authors.Add(new Author { Id = 2, Name = "Fatmanur", Surname = "Arı" });

List<Blog> blogs = new();

blogs.Add(new Blog { Id = 1, Title = "Deneme yazısı 1", AuthorId = 1 });
blogs.Add(new Blog { Id = 2, Title = "Deneme yazısı 2", AuthorId = 1 });
blogs.Add(new Blog { Id = 3, Title = "Deneme yazısı 3", AuthorId = 2 });
blogs.Add(new Blog { Id = 4, Title = "Deneme yazısı 4", AuthorId = 2 });


foreach (Author author in authors)
{
    author.WriteToConsole();
    foreach (Blog blog in blogs.Where(x => x.AuthorId == author.Id).ToList())
    {
        blog.WriteToConsole();
    }
    Console.WriteLine(new string('-', 50));
}

