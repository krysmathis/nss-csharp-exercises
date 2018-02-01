using System;
using System.ComponentModel.DataAnnotations;

namespace MusicHistory.Models
{
    public class Song 
    {
        [Key]
        public int SongId { get; set; }
        [Required]
        [StringLength(55)]
        public string Title { get; set; }
        public int SongLength {get; set;}
        public string ReleaseDate {get; set;}
        public int GenreId { get; set; }
        public Genre Genre {get; set;}
        public int Artistid {get; set;}
        public Artist Artist {get; set;}
        public int AlbumId {get; set;}
        public Album Album {get; set;}
    }
}