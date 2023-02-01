using BookLibrary;
using DbFirstLibrary;
using Microsoft.EntityFrameworkCore;

//IEnumerable<Author> CreateFakeData()
//{
//    var authors = new List<Author>
//    {
//        new Author
//        {
//            Name = "Jane Austen", Books = new List<Book>
//            {
//                new Book{Title = "Emma", YearOfPubliction = 1815},
//                new Book{Title = "Persuasion", YearOfPubliction = 1818},
//                new Book{Title = "Mansfield Park", YearOfPubliction = 1814}
//            }
//        },
//        new Author
//        {
//            Name = "Ian Fleming", Books = new List<Book>
//            {
//                new Book{Title = "Dr No", YearOfPubliction = 1958},
//                new Book{Title = "Goldfinger", YearOfPubliction = 1959},
//                new Book{Title = "From Russia with Love", YearOfPubliction = 1957}
//            }
//        }
//    };
//    return authors;
//}

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
    //                  where b.YearOfPubliction > 1900
    //                  select b;

    //foreach (var book in recentBooks.Include(b => b.Author))
    //{
    //    Console.WriteLine($"{book} is by {book.Author}");
    //}
}

{
    var options = new DbContextOptionsBuilder<MyLocalLibraryContext>()
        .UseSqlite("Filename=../../../MyLocalLibrary.db")
        .Options;

    using var db = new MyLocalLibraryContext(options);

    db.Database.EnsureCreated();

    var recentBooks = from b in db.Books
                      where b.YearOfPubliction > 1900
                      select b;

    foreach (var book in recentBooks.Include(b => b.Author))
    {
        Console.WriteLine($"{book} is by {book.Author}");
    }
}