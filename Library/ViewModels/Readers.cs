using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.ViewModels
{
    public class Readers
    {
        public int ID { get; set; }
        public string ReaderName { get; set; }
        public string Email { get; set; }
        public string CardNumber { get; set; }
        public string Role { get; internal set; }
    }
}