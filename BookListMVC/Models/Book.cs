using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListMVC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Price { get; set; }
    }
}
