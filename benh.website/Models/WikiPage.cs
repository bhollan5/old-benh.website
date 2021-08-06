﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace benh.website.Models
{
    public class WikiPage
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastUpdate { get; set; }
        public string Content { get; set; }
    }
}
