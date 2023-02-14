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
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; } // maybe make this a boolean "bool"
        public string Lent_To { get; set; }
        public string Notes { get; set; }

    }
}
