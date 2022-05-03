﻿using System.ComponentModel.DataAnnotations;

namespace MVCMovies.Models
{
    public class UserRate
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [Range(1,5)]
        public int Stars { get; set; }
        public string? Comment { get; set; }
    }
}