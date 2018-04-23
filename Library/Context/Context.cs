using System.Data.Entity;

namespace Library.Context
{
    public class Context : DbContext
    {
        public DbSet<Models.Author> Authors { get; set; }
        public DbSet<Models.BooksData> BooksData { get; set; }
        public DbSet<Models.Genre> Genres { get; set; }
        public DbSet<Models.Reader> Readers { get; set; }
        public DbSet<Models.Books> Books { get; set; }
        public DbSet<Models.CheckOut> CheckOutLedger { get; set; }
    }
}
