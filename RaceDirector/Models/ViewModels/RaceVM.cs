﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RaceDirector.Models.ViewModels
{
    public class RaceVM
    {
        public int Id { get; set; }
        
        public string TrackName { get; set; }
        
        public string RaceClassName { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public IEnumerable<RaceResultVM> Results { get; set; }

        internal void InitializeAfterMap(Race source)
        {
            TrackName = source?.Track?.Name;
            RaceClassName = source?.Class?.Name;
        }
    }
}
