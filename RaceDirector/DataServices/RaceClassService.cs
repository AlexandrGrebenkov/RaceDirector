using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaceDirector.Data;
using RaceDirector.Models;

namespace RaceDirector.DataServices
{
    public class RaceClassService
    {
        ApplicationDbContext context;

        public RaceClassService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<RaceClass> GetAll()
        {
            return context.RaceClasses;
        }
    }
}
