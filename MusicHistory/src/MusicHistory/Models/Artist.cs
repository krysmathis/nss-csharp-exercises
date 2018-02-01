using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicHistory.Models
{
    public class Artist
    {
        public int ArtistId {get; set;}
        public string ArtistName { get; set; }  
        public int YearEstablished { get; set; }

        // The one to many relationship is show here
        public ICollection<Song> Songs;
    }

    

   
}