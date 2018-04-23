using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library.Models
{
    public class Books
    {
        public int ID { get; set; }
        public bool IsCheckedOut { get; set; }
        public DateTime? DueBackDate { get; set; }
        public string Condition { get; set; }

        public int? BooksDataId { get; set; }
        public virtual BooksData BooksData { get; set; } 
    }
}