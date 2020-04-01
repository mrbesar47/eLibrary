using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eLibrary.Models
{
    public class Book
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }



    }
}
