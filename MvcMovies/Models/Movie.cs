﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace MvcMovies.Models
{
    public class Movie
    {
        
        public int ID { get; set; }
        [StringLength(60, MinimumLength =3)]
        public string Title { get; set; }
        [Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }
        [Range(1,100)]
        [Required]
        
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
    public class MovieDbContext :DbContext
        {
        public DbSet<Movie> Movies { get; set; }


        }
}