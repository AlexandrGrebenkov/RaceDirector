using System;

namespace RaceDirector.Models.ViewModels
{
    public class RaceResultVM
    {
        public int Id { get; set; }

        public string TrackName { get; set; }
        public string RaceClassName { get; set; }
        public string RaceDate { get; set; }

        public string DriverFullName { get; set; }

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
