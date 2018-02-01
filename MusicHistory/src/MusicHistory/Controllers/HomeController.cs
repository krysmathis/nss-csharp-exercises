using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicHistory.Models;
using System.Text.Encodings.Web;

namespace MusicHistory.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "This is the default action.";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Krys()
        {
        
            ViewData["FullName"] = "Krys Mathis";
            return View();
        }

        public IActionResult HelloWorld(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            
            
            return View();
        }

        public IActionResult AlbumDetails()
        {
            ViewData["Message"] = "Album Details.";

            return View();
        }

        public IActionResult ArtistDetails()
        {
            ViewData["Message"] = "Artist Details.";

            return View();
        }

        public IActionResult Artists()
        {
            ViewData["Message"] = "Artists";

            return View();
        }

        public IActionResult ListAllAlbums()
        {
            ViewData["Message"] = "List all Albums.";

            return View();
        }

        public IActionResult ListAllSongs()
        {
            ViewData["Message"] = "List all songs from an album.";

            return View();
        }

        public IActionResult SingleSong()
        {
            ViewData["Message"] = "Single Song Details.";

            return View();
        }
        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
