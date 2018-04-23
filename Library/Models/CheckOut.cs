using System;

namespace Library.Models
{
    public class CheckOut
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }

        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int? BooksId { get; set; }
        public virtual Books Book { get; set; }
        public int? ReaderId { get; set; }
        public virtual Reader Reader { get; set; }
    }
}