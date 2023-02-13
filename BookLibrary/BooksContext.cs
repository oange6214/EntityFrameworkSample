using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BookLibrary
{
    public class BooksContext : DbContext
    {
        public BooksContext()
        {

        }

        public BooksContext(DbContextOptions<BooksContext> options) 
            : base(options) 
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlite(@"Filename=../EntityFramework/MyLocalLibrary.db");
                //optionsBuilder.UseSqlite(@"Filename=../../../MyLocalLibrary.db");
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksLibrary;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            var books = modelBuilder.Entity<Book>();

            books.ToTable("Volumes");

            books.Property(b => b.Title).IsRequired();
        }

        //public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
