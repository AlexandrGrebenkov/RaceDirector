using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RaceDirector.Data;
using RaceDirector.Models;

namespace RaceDirector.DataServices
{
    public class RaceService
    {
        ApplicationDbContext context;

        public RaceService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<RaceClass> GetAllRaceClasses()
        {
            return context.RaceClasses;
        }

        public void AddNewRace(Race race)
        {
            if (race.Class == null)
            {
                race.Class = context.RaceClasses.Find(race.RaceClassId);
            }
            if (race.Track == null)
            {
                race.Track = context.Tracks.Find(race.TrackId);
            }
            context.Races.Add(race);
            context.SaveChanges();
        }

        public IEnumerable<Race> GetAllRaces()
        {
            return context.Races;
        }

        public Race GetRace(int id)
        {
            return context.Races
                .Include(_ => _.Class)
                .Include(_ => _.Track)
                .Include(_ => _.Results)
                .FirstOrDefault(_ => _.Id == id);
        }
    }
}
