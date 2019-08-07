using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDirector.Models
{
    /// <summary>Гонка</summary>
    public class Race : Entity
    {
        /// <summary>Класс</summary>
        public RaceClass Class { get; set; }
        public int RaceClassId { get; set; }

        public Track Track { get; set; }
        public int TrackId { get; set; }

        /// <summary>Дата проведения гонки</summary>
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        /// <summary>Результаты гонки</summary>
        public IEnumerable<RaceResult> Results { get; set; }
    }
}
