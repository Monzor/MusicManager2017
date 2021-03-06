﻿using System.ComponentModel.DataAnnotations;

namespace MusicManager2017.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        [Required(ErrorMessage = "Please enter a name for the Artist")]
        public string Name { get; set; }

        public string Bio { get; set; }
    }
}