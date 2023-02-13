using BookLibrary;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace EFCoreWeb.Models
{
    public static class BookModelExtensions
    {
        public static IQueryable<BookModel> ToModel(this IQueryable<Book> source)
        {
            return source.Select(b => new BookModel
            {
                Id = b.Id,
                Title = b.Title,
                YearOfPublication = (int)b.YearOfPublication,
                Author = b.Author.Name
            });
        }
    }

    public class BookModel
    {
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Title { get; set; }
        [Display(Name = "Year of Publication")]
        public int YearOfPublication { get; set; }
        public string Author { get; set; }

        public BookModel()
        {

        }

        public BookModel(Book entity)
        {
            Id = entity.Id;
            Title = entity.Title;
            YearOfPublication = (int)entity.YearOfPublication;
            Author = entity.Author.Name;
        }
    }
}
