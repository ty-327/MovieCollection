﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class EnterMovieModel
    {
        [Key]
        [Required(ErrorMessage = "Movie ID Required!")]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Movie Title Required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Movie Year Required!")]
        [Range(1800, 2200, ErrorMessage = "Please enter a valid year.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Movie Director Required!")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Movie Rating Required!")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent_To { get; set; }

        public string Notes { get; set; }

        //Build foreign key relationship
        [Required(ErrorMessage = "Movie Category Required!")]
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Movie Category Required!")]
        public Category Category { get; set; }

    }
}
