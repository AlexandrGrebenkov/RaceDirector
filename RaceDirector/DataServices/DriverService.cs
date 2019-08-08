using System.Collections.Generic;
using RaceDirector.Data;
using RaceDirector.Models;

namespace RaceDirector.DataServices
{
    public class DriverService
    {
        ApplicationDbContext context;

        public DriverService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Driver> GetAllDrivers()
        {
            return context.Drivers;
        }

        public Driver GetDriver(int id)
        {
            return context.Drivers.Find(id);
        }

        public void DeleteDriver(int id)
        {
            var driver = new Driver() { Id = id };
            context.Drivers.Remove(driver);
            context.SaveChanges();
        }

        public void AddNewDriver(Driver driver)
        {
            context.Drivers.Add(driver);
            context.SaveChanges();
        }
    }
}
