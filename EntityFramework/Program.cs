using BookLibrary;
using DbFirstLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

IEnumerable<BookLibrary.Author> CreateFakeData()
{
var authors = new List<BookLibrary.Author>
        {
            new BookLibrary.Author
            {
                Name = "Jane Austen", Books = new List<BookLibrary.Book>
                {
                    new BookLibrary.Book{Title = "Emma", YearOfPublication = 1815},
                    new BookLibrary.Book{Title = "Persuasion", YearOfPublication = 1818},
                    new BookLibrary.Book{Title = "Mansfield Park", YearOfPublication = 1814}
                }
            },
            new BookLibrary.Author
            {
                Name = "Ian Fleming", Books = new List<BookLibrary.Book>
                {
                    new BookLibrary.Book{Title = "Dr No", YearOfPublication = 1958},
                    new BookLibrary.Book{Title = "Goldfinger", YearOfPublication = 1959},
                    new BookLibrary.Book{Title = "From Russia with Love", YearOfPublication = 1957}
                }
            }
        };
return authors;
}

{
    //var authors = CreateFakeData();

    //foreach(var author in authors)
    //{
    //    Console.WriteLine($"{author} wrote...");

    //    foreach (var book in author.Books)
    //        Console.WriteLine($"    {book}");

    //    Console.WriteLine();
    //}
}

{
    //var options = new DbContextOptionsBuilder<BooksContext>()
    //    .UseSqlite("Filename=../../../MyLocalLibrary.db")
    //    .Options;

    //using var db = new BooksContext(options);

    //db.Database.EnsureCreated();

    //var authors = CreateFakeData();

    //db.Authors.AddRange(authors);

    //db.SaveChanges();
}


{
    //var options = new DbContextOptionsBuilder<BooksContext>()
    //.UseSqlite("Filename=../../../MyLocalLibrary.db")
    //.Options;

    //using var db = new BooksContext(options);

    //db.Database.EnsureCreated();

    //foreach (var author in db.Authors.Include(a => a.Books))
    //{
    //    Console.WriteLine($"{author} wrote...");

    //    foreach (var book in author.Books)
    //        Console.WriteLine($"    {book}");

    //    Console.WriteLine();
    //}
}

{
    //var options = new DbContextOptionsBuilder<BooksContext>()
    //    .UseSqlite("Filename=../../../MyLocalLibrary.db")
    //    .Options;

    //using var db = new BooksContext(options);

    //db.Database.EnsureCreated();

    //var recentBooks = from b in db.Books
    //                  where b.YearOfPublication > 1900
    //                  select b;

    //foreach (var book in recentBooks.Include(b => b.Author))
    //{
    //    Console.WriteLine($"{book} is by {book.Author}");
    //}
}

{
    //var options = new DbContextOptionsBuilder<MyLocalLibraryContext>()
    //    .UseSqlite("Filename=../../../MyLocalLibrary.db")
    //    .Options;

    //using var db = new MyLocalLibraryContext(options);

    //db.Database.EnsureCreated();

    //var recentBooks = from b in db.Books
    //                  where b.YearOfPublication > 1900
    //                  select b;

    //foreach (var book in recentBooks.Include(b => b.Author))
    //{
    //    Console.WriteLine($"{book} is by {book.Author}");
    //}
}


{
    //// DbContext 有設定 OnConfiguring
    //using var db = new BooksContext();

    //db.Database.EnsureCreated();

    //foreach (var author in db.Authors.Include(a => a.Books))
    //{
    //    Console.WriteLine($"{author} wrote...");

    //    foreach (var book in author.Books)
    //        Console.WriteLine($"    {book}");

    //    Console.WriteLine();
    //}
}

{
    //IConfiguration config = new ConfigurationBuilder()
    //    .AddJsonFile("appsettings.json")
    //    .Build();

    //var options = new DbContextOptionsBuilder<BooksContext>()
    //.UseSqlite(config.GetConnectionString("BooksLibrary:SQLite"))
    //.Options;

    //using var db = new BooksContext(options);

    //db.Database.EnsureCreated();

    //foreach (var author in db.Authors.Include(a => a.Books))
    //{
    //    Console.WriteLine($"{author} wrote...");

    //    foreach (var book in author.Books)
    //        Console.WriteLine($"    {book}");

    //    Console.WriteLine();
    //}
}


{
    IConfiguration config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

    var options = new DbContextOptionsBuilder<BooksContext>()
        .UseSqlServer(config.GetConnectionString("BooksLibrary:SQLServer"))
        .Options;

    using var db = new BooksContext(options);

    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    //var authors = CreateFakeData();

    //db.Authors.AddRange(authors);

    db.SaveChanges();
}