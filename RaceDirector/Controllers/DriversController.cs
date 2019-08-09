using System;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaceDirector.DataServices;
using RaceDirector.Models;
using RaceDirector.Models.ViewModels;

namespace RaceDirector.Controllers
{
    public class DriversController : Controller
    {
        IMapper Mapper { get; }
        IEntityRepository<Driver> DriverRepository;

        public DriversController(IMapper mapper,
                                 IEntityRepository<Driver> driverRepository)
        {
            Mapper = mapper;
            DriverRepository = driverRepository;
        }

        // GET: Drivers
        public ActionResult Index()
        {
            var drivers = DriverRepository.GetAll();
            var vm = drivers.Select(_ => Mapper.Map<DriverVM>(_));
            return View(vm);
        }

        // GET: Drivers/Details/5
        public ActionResult Details(int id)
        {
            var driver = DriverRepository.Get(id);
            var vm = Mapper.Map<DriverVM>(driver);
            return View(vm);
        }

        // GET: Drivers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drivers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var driver = new Driver()
                {
                    FirstName = collection["FirstName"],
                    LastName = collection["LastName"],
                    DateOfBirth = DateTime.Parse(collection["DateOfBirth"])
                };
                DriverRepository.Insert(driver);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Drivers/Edit/5
        public ActionResult Edit(int id)
        {
            var driver = DriverRepository.Get(id);
            var vm = Mapper.Map<DriverVM>(driver);
            return View(vm);
        }

        // POST: Drivers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var driver = DriverRepository.Get(id);
                driver.FirstName = collection["FirstName"];
                driver.LastName = collection["LastName"];
                driver.DateOfBirth = DateTime.Parse(collection["DateOfBirth"]);
                DriverRepository.Update(driver);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Drivers/Delete/5
        public ActionResult Delete(int id)
        {
            var driver = DriverRepository.Get(id);
            var vm = Mapper.Map<DriverVM>(driver);
            return View(vm);
        }

        // POST: Drivers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var driver = DriverRepository.Get(id);
                DriverRepository.Delete(driver);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}