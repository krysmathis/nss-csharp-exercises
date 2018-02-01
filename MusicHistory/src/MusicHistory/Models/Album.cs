using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicHistory.Models
{
    public class Album 
    {
        [Key]
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public int AlbumLength { get; set; }
        public string Label {get; set;}
        public int ArtistId { get; set; }
        public int GenreId  {get;set;}

        // The one to many relationship is show here
        public ICollection<Song> Songs;
    }
}