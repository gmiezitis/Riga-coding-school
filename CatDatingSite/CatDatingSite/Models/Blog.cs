﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CatDatingSite.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

       [Required]

       [EmailAddress]
        public string Email { get; set; }
       
        [Required]
        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime BlogCreated { get; set; }

        public DateTime BlogModified { get; set; }

        public class Index
        {
        }
    }
}