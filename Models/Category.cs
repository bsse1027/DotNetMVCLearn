﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string name { get; set; }

        [DisplayName("Display Order")]
        public int DisplayCount { get; set; }
    }
}
