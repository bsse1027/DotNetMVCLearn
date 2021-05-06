using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string name { get; set; }

        public int DisplayCount { get; set; }
    }
}
