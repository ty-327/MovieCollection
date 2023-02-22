using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class EnterMovieModel
    {
        [Key]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Title required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year required!")]  
        [Range(1800, 2200, ErrorMessage = "Please enter a valid year.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director required!")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating Required!")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent_To { get; set; }

        public string Notes { get; set; }

        //Build foreign key relationship
        [Required(ErrorMessage = "Category Required!")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
