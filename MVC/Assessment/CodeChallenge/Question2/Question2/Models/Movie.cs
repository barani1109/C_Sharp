using System;
using System.ComponentModel.DataAnnotations;

namespace Question2.Models
{
    public class Movie
    {
        [Key]
        public int Mid { get; set; }

        [Required]
        public string MovieName { get; set; }

        [Required]
        public string DirectorName { get; set; }

        [Required]
        public DateTime DateOfRelease { get; set; }
    }
}