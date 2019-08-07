using System;
using System.Collections.Generic;

namespace RaceDirector.Models
{
    /// <summary>Гонка</summary>
    public class Race : Entity
    {
        /// <summary>Класс</summary>
        public RaceClass Class { get; set; }
        public int RaceClassId { get; set; }

        /// <summary>Дата проведения гонки</summary>
        public DateTime Date { get; set; }

        /// <summary>Результаты гонки</summary>
        public IEnumerable<RaceResult> Results { get; set; }
    }
}
