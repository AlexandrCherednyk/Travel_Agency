using AutoMapper;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIL.Models;
using UIL.Models.PageViewModel;

namespace UIL.Controllers
{
    public class HotelController : Controller
    {
        private readonly ILogger<HomeController> Logger;
        private readonly IMapper Mapper;

        private readonly IHotelService HotelService;

        private readonly List<HotelViewModel> Hotels;

        public HotelController(ILogger<HomeController> logger, IMapper mapper, IHotelService hotelService)
        {
            Logger = logger;
            Mapper = mapper;
            HotelService = hotelService;

            Hotels = Mapper.Map<List<HotelViewModel>>(HotelService.GetHotelList());
        }

        // GET: HotelController
        public ActionResult Index(int page=1)
        {
            int pageSize = 10;
            IEnumerable<HotelViewModel> hotelsPerPages = Hotels.Skip((page - 1) * pageSize).Take(pageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = Hotels.Count };
            HotelPageViewModel ivm = new HotelPageViewModel { PageInfo = pageInfo, Hotels = hotelsPerPages };
            return View(ivm);
        }

        // GET: HotelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HotelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HotelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HotelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HotelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HotelController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
