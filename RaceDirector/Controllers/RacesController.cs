using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaceDirector.DataServices;
using RaceDirector.Models.ViewModels;

namespace RaceDirector.Controllers
{
    public class RacesController : Controller
    {
        RaceClassService RaceClassService { get; }
        IMapper Mapper { get; }

        public RacesController(RaceClassService raceClassService,
                               IMapper mapper)
        {
            RaceClassService = raceClassService;
            Mapper = mapper;
        }

        // GET: Races
        public ActionResult Index()
        {
            var races = new RaceVM[0];
            return View(races);
        }

        // GET: Races/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Races/Create
        public ActionResult Create()
        {
            var possib = RaceClassService.GetAll().Select(_ => Mapper.Map<RaceClassVM>(_));
            var vm = new CreateRaceVM()
            {
                RaceClassName = possib.FirstOrDefault()?.Name,
                PossibleRaceClasses = possib,
                RaceDate = DateTime.Now
            };
            return View(vm);
        }

        // POST: Races/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Races/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Races/Edit/5
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

        // GET: Races/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Races/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}