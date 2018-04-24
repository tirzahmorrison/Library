using System.Linq;
using System.Web.Http;

namespace Library.Controllers
{
    public class BooksDataController : ApiController
    {
        private Context.Context db = new Context.Context();

        [Route("admin/books")]
        [HttpPost]
        public Models.Books AddBook(Models.Books book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return book;
        }
        [Route("admin/bookdata")]
        [HttpPost]
        public Models.BooksData AddBookData(Models.BooksData bookData)
        {
            db.BooksData.Add(bookData);
            db.SaveChanges();
            return bookData;
        }
        [Route("admin/author")]
        [HttpPost]
        public Models.Author AddAuthor(Models.Author author)
        {
            db.Authors.Add(author);
            db.SaveChanges();
            return author;
        }
        [Route("admin/checkedout")]
        [HttpGet]
        public IQueryable<Models.Books> GetCheckedOutBooks()
        {
            return db.Books.Where(b => b.IsCheckedOut);
        }
    }
}
