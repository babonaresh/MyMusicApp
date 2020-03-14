using MyMusicApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyMusicApp.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> upcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
    }
}