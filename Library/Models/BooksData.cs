namespace Library.Models
{
    public class BooksData
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public string IsbnNumber { get; set; }

        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}