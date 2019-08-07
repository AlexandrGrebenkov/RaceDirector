using System;

namespace RaceDirector.Models
{
    /// <summary>Результат пилота в гонке</summary>
    public class RaceResult : Entity
    {
        /// <summary></summary>
        public Race Race { get; set; }
        public int RaceId { get; set; }

        /// <summary></summary>
        public Driver Driver { get; set; }
        public int DriverId { get; set; }

        /// <summary>Занятое место</summary>
        public int Position { get; set; }

        /// <summary>Количество кругов</summary>
        public double Laps { get; set; }

        /// <summary>Время в квалификации</summary>
        public TimeSpan LapTime { get; set; }

        /// <summary>Лучшее время в гонке</summary>
        public TimeSpan BestTime { get; set; }
    }
}
