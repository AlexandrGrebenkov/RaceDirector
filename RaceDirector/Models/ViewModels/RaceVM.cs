using System;
using System.Collections.Generic;

namespace RaceDirector.Models.ViewModels
{
    public class RaceVM
    {
        public int Id { get; set; }

        public string TrackName { get; set; }
        public string RaceClassName { get; set; }
        public string RaceDate { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<RaceResultVM> Results { get; set; }
    }
}
