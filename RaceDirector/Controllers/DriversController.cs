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
        DriverService driverService { get; }
        IMapper Mapper { get; }

        public DriversController(DriverService driverService, IMapper mapper)
        {
            this.driverService = driverService;
            Mapper = mapper;
        }

        // GET: Drivers
        public ActionResult Index()
        {
            var drivers = driverService.GetAllDrivers();
            var vm = drivers.Select(_ => Mapper.Map<DriverVM>(_));
            return View(vm);
        }

        // GET: Drivers/Details/5
        public ActionResult Details(int id)
        {
            var driver = driverService.GetDriver(id);
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
                driverService.AddNewDriver(driver);

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
            var driver = driverService.GetDriver(id);
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
                // TODO: Add update logic here

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
            var driver = driverService.GetDriver(id);
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
                driverService.DeleteDriver(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}