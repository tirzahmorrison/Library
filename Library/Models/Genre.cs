﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library.Models
{
    public class Genre
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
    }
}