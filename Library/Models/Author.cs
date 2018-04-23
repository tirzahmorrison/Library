using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Born { get; set; }
        public string Died { get; set; }
    }
}