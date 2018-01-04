using System;
using System.Collections.Generic;
using System.Linq;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a list to hold tuples representing good songs
            List<(string artist, string song)> goodSongs = new List<(string artist, string song)>();
            
            /*
                Initialize a HashSet to hold all songs (pre-Nickelback screening)
                Load them into the HashSet one by one
             */

            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();
            allSongs.Add(("Metallica", "Enter Sandman"));
            allSongs.Add(("Kendrick Lamar", "HUMBLE"));
            allSongs.Add(("St. Vincent", "Pills"));
            allSongs.Add(("Sarah Harmer","Lodestar"));
            allSongs.Add(("Big Thief", "Paul"));
            allSongs.Add(("Nickelback", "Photograph"));
            allSongs.Add(("Nickelback", "How You Remind Me"));
            
            
            foreach((string,string) song in allSongs) {
                if (song.Item1 != "Nickelback") {
                    goodSongs.Add(song);
                }
            }  
            
            // -- Alternate implementations
            // -- Remove the bad songs from allSongs - does not
            //allSongs.RemoveWhere(x => x.Item1 == "Nickelback");
            
            // -- filter all songs to only those that are Nickelback and convert it to list
            //goodSongs = allSongs.Where(x=> x.Item1 != "Nickelback").ToList();
             
            foreach((string,string) song in goodSongs) {
                Console.WriteLine($"'{song.Item2}' by {song.Item1} is good.");
            }
        }
    }
}
