using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RaceDirector.Models.ViewModels
{
    public class CreateRaceVM
    {
        public string TrackName { get; set; }

        public string RaceClassName { get; set; }
        [Required]
        public DateTime RaceDate { get; set; }

        public IEnumerable<RaceClassVM> PossibleRaceClasses { get; set; }
    }
}
