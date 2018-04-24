using System;
using System.Linq;
using System.Web.Http;

namespace Library.Controllers
{
    public class LibraryController : ApiController
    {
        private Context.Context db = new Context.Context();

        [ApiKeyAuthentication]
        [Route("library/search")]
        [HttpGet]
        public IQueryable<Models.BooksData> GetBooksData(string query, string field)
        {
            if(field == "genre")
            {
                var genre = db.Genres.First(d => d.DisplayName == query);
                return db.BooksData.Where(g => g.GenreId == genre.ID);
            }

            else if (field == "title")
            {
                return db.BooksData.Where(t => t.Title == query);
            }
            else if (field == "author")
            {
                var author = db.Authors.First(a => a.FullName == query);
                return db.BooksData.Where(r => r.AuthorId == author.ID);
            }
            else if (field == "checkedInStatus")
            {
                var checkedInStatus = db.Books.Where(c => c.IsCheckedOut == Convert.ToBoolean(query)).Select(s => s.BooksDataId);
                return db.BooksData.Where(b => checkedInStatus.Contains(b.ID));
            }
            return db.BooksData;
        }
        [Route("library/checkin/{ID}")] 
        [HttpPost]
        public Models.Books CheckInBook(int ID)
        {
            var book = db.Books.First(i => i.ID == ID);
            book.IsCheckedOut = false;
            db.SaveChanges();
            return book;
        }
        [Route("library/checkout/{ID}")] 
        [HttpPost]
        public Models.Books CheckOutBook(int ID, string Email)
        {
            var book = db.Books.First(i => i.ID == ID);
            book.IsCheckedOut = true;
            db.SaveChanges();
            var theDude = db.Readers.First(x => x.Email == Email);
            db.CheckOutLedger.Add(new Models.CheckOut {
                TimeStamp = DateTime.Now,
                Book = book,
                Reader = theDude,
            });
            db.SaveChanges();
            return book;
        }
        [Route("library/itemsout")]
        [HttpGet]
        public IQueryable<Models.CheckOut> GetItemsOut(string email)
        {
            return db.CheckOutLedger.Where(r => r.Reader.Email == email);
        }
    }
}
