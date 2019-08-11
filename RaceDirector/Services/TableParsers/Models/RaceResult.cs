using System;
using System.Collections.Generic;

namespace RaceDirector.Services.TableParsers.Models
{
    public class RaceResult
    {
        public string ClassName { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Organizer { get; set; }
        public string RaceDirector { get; set; }
        public string TrackName { get; set; }

        public IEnumerable<RowResult> Results;
    }
}
