namespace Library.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Library.Context.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Library.Context.Context context)
        {
            context.Authors.AddOrUpdate(new Models.Author[] {
                new Models.Author
                {
                    FullName = "Lewis Carroll",
                    Born = "January 27, 1832",
                    Died = "January 14, 1898",
                },
                    new Models.Author
                {
                    FullName = "J.K. Rowling",
                    Born = "July 31, 1965 ",
                    Died = "",
                },
                    new Models.Author
                {
                    FullName = "Homer",
                    Born = "7th century BC",
                    Died = "7th century BC",
                },
                    new Models.Author
                {
                    FullName = "Stephen King",
                    Born = "September 21, 1947",
                    Died = "",
                },
                    new Models.Author
                {
                    FullName = "Ernest Cline",
                    Born = "March 29, 1972",
                    Died = "",
                },
                    new Models.Author
                {
                    FullName = "Herman Melville",
                    Born = "August 1, 1819",
                    Died = "September 28, 1891",
                },
                    new Models.Author
                {
                    FullName = "Fyodor Dostoyevsky",
                    Born = "November 11, 1821",
                    Died = "February 9, 1881",
                },
                    new Models.Author
                {
                    FullName = "J.R.R. Tolkien",
                    Born = "January 3, 1892",
                    Died = "September 2, 1973",
                },
                    new Models.Author
                {
                    FullName = "George R.R. Martin",
                    Born = "September 20, 1948",
                    Died = "",
                },
                    new Models.Author
                {
                    FullName = "Beatrix Potter",
                    Born = "July 28, 1866",
                    Died = "December 22, 1943",
                },
                    new Models.Author
                {
                    FullName = "Anne Rice",
                    Born = "October 4, 1941",
                    Died = "",
                },
                    new Models.Author
                {
                    FullName = "Mark Z. Danielewski",
                    Born = "March 5, 1966",
                    Died = "",
                },
                    new Models.Author
                {
                    FullName = "Dr. Suess",
                    Born = "March 2, 1904",
                    Died = "September 24, 1991",
                },
                    new Models.Author
                {
                    FullName = "William Shakespeare",
                    Born = "April 1564",
                    Died = "April 23, 1616",
                },
                    new Models.Author
                {
                    FullName = "Leo Tolstoy",
                    Born = "September 9, 1828",
                    Died = "November 20, 1910",
                },
                    new Models.Author
                {
                    FullName = "George Orwell",
                    Born = "June 25, 1903",
                    Died = "January 21, 1950",
                },
                    new Models.Author
                {
                    FullName = "Joseph Conrad",
                    Born = "December 3, 1857",
                    Died = "August 3, 1924",
                },
                    new Models.Author
                {
                    FullName = "Charles Dickens",
                    Born = "February 7, 1812",
                    Died = "June 9, 1870",
                },
                    new Models.Author
                {
                    FullName = "Emily Brontë",
                    Born = "April 21, 1816",
                    Died = "March 31, 1855",
                },
                    new Models.Author
                {
                    FullName = "Virginia Woolf",
                    Born = "January 25, 1882",
                    Died = "March 28, 1941",
                },
                    new Models.Author
                {
                    FullName = "Arthur C. Clarke",
                    Born = "December 16, 1917",
                    Died = "March 19, 2008",
                },
            });
            context.SaveChanges();

            context.Genres.AddOrUpdate(new Models.Genre[] {
                new Models.Genre
                {
                    DisplayName = "Fantasy",
                },
                    new Models.Genre
                {
                    DisplayName = "Thriller",
                },
                    new Models.Genre
                {
                    DisplayName = "Science Fiction",
                },
                    new Models.Genre
                {
                    DisplayName = "Romance",
                },
                    new Models.Genre
                {
                    DisplayName = "Drama",
                },
                    new Models.Genre
                {
                    DisplayName = "Adventure",
                },
                    new Models.Genre
                {
                    DisplayName = "Mystery",
                },
                    new Models.Genre
                {
                    DisplayName = "Children's",
                },
            });
            context.SaveChanges();

            context.Readers.AddOrUpdate(new Models.Reader[] {
                new Models.Reader
                {
                    ReaderName = "Luke Skywalker",
                    Email = "MySisterIsHot@hotmail.com",
                    CardNumber = "1-433-011-0988",
                    Role ="Reader",
                },
                    new Models.Reader
                {
                    ReaderName = "Leia Organa",
                    Email = "myTwinIsaPerv@hotmail.com",
                    CardNumber = "1-433-011-0989",
                    Role ="Reader",
                },
                    new Models.Reader
                {
                    ReaderName = "Han Solo",
                    Email = "iShotFirst@hotmail.com",
                    CardNumber = "1-433-011-0984",
                    Role ="Reader",
                },
                    new Models.Reader
                {
                    ReaderName = "Greedo",
                    Email = "NoIshotFirst@hotmail.com",
                    CardNumber = "1-433-011-0970",
                    Role ="Reader",
                },
                    new Models.Reader
                {
                    ReaderName = "Anakin Skywalker",
                    Email = "joinTheDarkside@hotmail.com",
                    CardNumber = "1-433-011-0983",
                    Role ="Reader",
                },
                    new Models.Reader
                {
                    ReaderName = "Ob-Wan Kenobi",
                    Email = "messageMeWhenYouNeedHelp@hotmail.com",
                    CardNumber = "1-433-011-0981",
                    Role = "Librarian",
                },
                    new Models.Reader
                {
                    ReaderName = "R2 D2",
                    Email = "beepBoopBeep@hotmail.com",
                    CardNumber = "1-433-011-0982",
                    Role = "Librarian",
                },
                    new Models.Reader
                {
                    ReaderName = "BB-8",
                    Email = "cuterThanR2@hotmail.com",
                    CardNumber ="1-433-011-0956",
                    Role = "Librarian",
                },
                    new Models.Reader
                {
                    ReaderName = "Sheev Palpatine",
                    Email = "traitorFace@hotmail.com",
                    CardNumber = "1-433-011-0980",
                    Role ="Reader",
                },
                    new Models.Reader
                {
                    ReaderName = "Rey Dunno",
                    Email = "whoIsMyDaddy?@hotmail.com",
                    CardNumber = "1-433-011-0987",
                    Role ="Reader",
                },
                    new Models.Reader
                {
                    ReaderName = "Kylo Ren",
                    Email = "emoBitch@hotmail.com",
                    CardNumber = "1-433-011-0990",
                    Role ="Reader",
                },
                    new Models.Reader
                {
                    ReaderName = "Padme Amidala",
                    Email = "naughtyCougar@hotmail.com",
                    CardNumber = "1-433-011-0991",
                    Role ="Reader",
                },
                    new Models.Reader
                {
                    ReaderName = "Jabba Hut",
                    Email = "HotForSlaves@hotmail.com",
                    CardNumber = "1-433-011-0988",
                    Role ="Reader",
                },
            });
            context.SaveChanges();

            context.BooksData.AddOrUpdate(new Models.BooksData[] {
                new Models.BooksData
                {
                    Title = "Alice's Adventures in Wonderland",
                    YearPublished = 1865,
                    IsbnNumber = "978-3-16-148410-0",
                    Author = context.Authors.First(a => a.FullName == "Lewis Carroll"),
                    Genre = context.Genres.First(g => g.DisplayName == "Fantasy"),
                },
                    new Models.BooksData
                {
                    Title = "Moby Dick",
                    YearPublished = 1851,
                    IsbnNumber = "978-3-16-148411-0",
                    Author = context.Authors.First(a => a.FullName == "Herman Melville"),
                    Genre = context.Genres.First(g => g.DisplayName == "Adventure"),
                },
                    new Models.BooksData
                {
                    Title = "Hamlet",
                    YearPublished = 1601,
                    IsbnNumber = "978-3-16-148412-0",
                    Author = context.Authors.First(a => a.FullName == "William Shakespeare"),
                    Genre = context.Genres.First(g => g.DisplayName == "Drama"),
                },
                    new Models.BooksData
                {
                    Title = "Othello",
                    YearPublished = 1603,
                    IsbnNumber = "978-3-16-148413-0",
                    Author = context.Authors.First(a => a.FullName == "William Shakespeare"),
                    Genre = context.Genres.First(g => g.DisplayName == "Drama"),
                },
                    new Models.BooksData
                {
                    Title = "Romeo and Juliet",
                    YearPublished = 1597,
                    IsbnNumber = "978-3-16-148433-0",
                    Author = context.Authors.First(a => a.FullName == "William Shakespeare"),
                    Genre = context.Genres.First(g => g.DisplayName == "Romance"),
                },
                    new Models.BooksData
                {
                    Title = "The Odyssey",
                    YearPublished = -800,
                    IsbnNumber = "978-3-16-148422-0",
                    Author = context.Authors.First(a => a.FullName == "Homer"),
                    Genre = context.Genres.First(g => g.DisplayName == "Adventure"),
                },
                    new Models.BooksData
                {
                    Title = "War and Peace",
                    YearPublished = 1899,
                    IsbnNumber = "978-3-16-148432-0",
                    Author = context.Authors.First(a => a.FullName == "Leo Tolstoy"),
                    Genre = context.Genres.First(g => g.DisplayName == "Drama"),
                },
                    new Models.BooksData
                {
                    Title = "The Brothers Karamazov",
                    YearPublished = 1879,
                    IsbnNumber = "978-3-16-147432-0",
                    Author = context.Authors.First(a => a.FullName == "Fyodor Dostoyevsky"),
                    Genre = context.Genres.First(g => g.DisplayName == "Mystery"),
                },
                    new Models.BooksData
                {
                    Title = "Crime and Punishment",
                    YearPublished = 1866,
                    IsbnNumber = "978-2-16-147432-0",
                    Author = context.Authors.First(a => a.FullName == "Fyodor Dostoyevsky"),
                    Genre = context.Genres.First(g => g.DisplayName == "Drama"),
                },
                    new Models.BooksData
                {
                    Title = "1984",
                    YearPublished = 1949,
                    IsbnNumber = "988-2-16-147432-0",
                    Author = context.Authors.First(a => a.FullName == "George Orwell"),
                    Genre = context.Genres.First(g => g.DisplayName == "Science Fiction"),
                },
                    new Models.BooksData
                {
                    Title = "Animal Farm",
                    YearPublished = 1945,
                    IsbnNumber = "978-2-18-147432-0",
                    Author = context.Authors.First(a => a.FullName == "George Orwell"),
                    Genre = context.Genres.First(g => g.DisplayName == "Drama"),
                },
                    new Models.BooksData
                {
                    Title = "Interview with the Vampire",
                    YearPublished = 1976,
                    IsbnNumber = "978-2-16-149432-0",
                    Author = context.Authors.First(a => a.FullName == "Anne Rice"),
                    Genre = context.Genres.First(g => g.DisplayName == "Thriller"),
                },
                    new Models.BooksData
                {
                    Title = "The Tale of Peter Rabbit",
                    YearPublished = 1901,
                    IsbnNumber = "978-2-16-147532-0",
                    Author = context.Authors.First(a => a.FullName == "Beatrix Potter"),
                    Genre = context.Genres.First(g => g.DisplayName == "Children's"),
                },
                    new Models.BooksData
                { 
                    Title = "Wuthering Heights",
                    YearPublished = 1801,
                    IsbnNumber = "978-2-16-142542-0",
                    Author = context.Authors.First(a => a.FullName == "Emily Brontë"),
                    Genre = context.Genres.First(g => g.DisplayName == "Drama"),
                },
                    new Models.BooksData
                {
                    Title = "To the Lighthouse",
                    YearPublished = 1920,
                    IsbnNumber = "978-2-16-172532-0",
                    Author = context.Authors.First(a => a.FullName == "Virginia Woolf"),
                    Genre = context.Genres.First(g => g.DisplayName == "Drama"),
                },
                    new Models.BooksData
                {
                    Title = "Heart of Darkness",
                    YearPublished = 1902,
                    IsbnNumber = "945-2-16-142532-0",
                    Author = context.Authors.First(a => a.FullName == "Joseph Conrad"),
                    Genre = context.Genres.First(g => g.DisplayName == "Thriller"),
                },
                    new Models.BooksData
                {
                    Title = "The Cat in the Hat",
                    YearPublished = 1957,
                    IsbnNumber = "978-2-96-142532-0",
                    Author = context.Authors.First(a => a.FullName == "Dr. Suess"),
                    Genre = context.Genres.First(g => g.DisplayName == "Children's"),
                },
                    new Models.BooksData
                {
                    Title = "One Fish, Two Fish, Red Fish, Blue Fish",
                    YearPublished = 1960,
                    IsbnNumber = "978-2-56-182532-0",
                    Author = context.Authors.First(a => a.FullName == "Dr. Suess"),
                    Genre = context.Genres.First(g => g.DisplayName == "Children's"),
                },
                    new Models.BooksData
                {
                    Title = "2001: A Space Odyssey",
                    YearPublished = 1968,
                    IsbnNumber = "978-2-56-182532-0",
                    Author = context.Authors.First(a => a.FullName == "Arthur C. Clarke"),
                    Genre = context.Genres.First(g => g.DisplayName == "Science Fiction"),
                },
                    new Models.BooksData
                {
                    Title = "Harry Potter and te Sorcerer's Stone",
                    YearPublished = 1997,
                    IsbnNumber = "978-2-56-882532-0",
                    Author = context.Authors.First(a => a.FullName == "J.K. Rowling"),
                    Genre = context.Genres.First(g => g.DisplayName == "Fantasy"),
                },
                    new Models.BooksData
                {
                    Title = "It",
                    YearPublished = 1986,
                    IsbnNumber = "978-2-56-872532-0",
                    Author = context.Authors.First(a => a.FullName == "Stephen King"),
                    Genre = context.Genres.First(g => g.DisplayName == "Thriller"),
                },
                    new Models.BooksData
                {
                    Title = "Ready Player One",
                    YearPublished = 2011,
                    IsbnNumber = "976-2-56-882532-0",
                    Author = context.Authors.First(a => a.FullName == "Ernest Cline"),
                    Genre = context.Genres.First(g => g.DisplayName == "Science Fiction"),
                },
                    new Models.BooksData
                {
                    Title = "The Hobbit",
                    YearPublished = 1937,
                    IsbnNumber = "978-2-56-482532-0",
                    Author = context.Authors.First(a => a.FullName == "J.R.R. Tolkien"),
                    Genre = context.Genres.First(g => g.DisplayName == "Fantasy"),
                },
                    new Models.BooksData
                {
                    Title = "A Game of Thrones",
                    YearPublished = 1996,
                    IsbnNumber = "978-2-56-888532-0",
                    Author = context.Authors.First(a => a.FullName == "George R.R. Martin"),
                    Genre = context.Genres.First(g => g.DisplayName == "Fantasy"),
                },
                    new Models.BooksData
                {
                    Title = "Oliver Twist",
                    YearPublished = 1838,
                    IsbnNumber = "978-1-56-882532-0",
                    Author = context.Authors.First(a => a.FullName == "Charles Dickens"),
                    Genre = context.Genres.First(g => g.DisplayName == "Drama"),
                },
                    new Models.BooksData
                {
                    Title = "House of Leaves",
                    YearPublished = 2000,
                    IsbnNumber = "0-375-70376-4",
                    Author = context.Authors.First(a => a.FullName == "Mark Z. Danielewski"),
                    Genre = context.Genres.First(g => g.DisplayName == "Thriller"),
                },
        });
            context.SaveChanges();

            context.Books.AddOrUpdate(new Models.Books[] {
                new Models.Books
                {
                    IsCheckedOut = true,
                    DueBackDate = DateTime.Parse("2018-04-25"),
                    BooksData = context.BooksData.First(b => b.Title == "Ready Player One"),

                },
                    new Models.Books
                {
                    IsCheckedOut = true,
                    DueBackDate = DateTime.Parse("2018-04-25"),
                    BooksData = context.BooksData.First(b => b.Title == "Othello"),

                },
                    new Models.Books
                {
                    BooksData = context.BooksData.First(b => b.Title == "Othello"),
                    IsCheckedOut = false,
                },
            });
            context.SaveChanges();

            context.CheckOutLedger.AddOrUpdate(new Models.CheckOut[] {
                new Models.CheckOut
                {
                    TimeStamp = DateTime.Now,
                    Reader = context.Readers.First(r => r.Email == "MySisterIsHot@hotmail.com"),
                    Book = context.Books.First(c => c.IsCheckedOut),
                },
                    new Models.CheckOut
                {
                    TimeStamp = DateTime.Now,
                    Reader = context.Readers.First(r => r.Email == "cuterThanR2@hotmail.com"),
                    Book = context.Books.First(c => c.IsCheckedOut == false),
                },
            });
            context.SaveChanges();
        }
    }
}


