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

        // GET: HotelController/Details/
        public ActionResult Details(Guid id, int page=1)
        {
            var hotel = Hotels.First(h => h.Id == id);

            if (hotel == null)
            { 
            }

            int pageSize = 10;
            IEnumerable<LodgingViewModel> lodgingsPerPages = hotel.Lodgings.Skip((page - 1) * pageSize).Take(pageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = hotel.Lodgings.Count };
            LodgingPageViewModel ivm = new LodgingPageViewModel { Hotel = hotel, PageInfo = pageInfo, Lodgings = lodgingsPerPages };

            return View(ivm);
        }

        [HttpGet]
        public ActionResult Reservation(Guid hotelId, Guid lodgingId)
        {
            var hotel = Hotels.First(h => h.Id == hotelId);
            var lodging = hotel.Lodgings.First(l => l.Id == lodgingId);

            Logger.LogInformation($"{hotel.MealsTypes[0].PricePerDay}");
            Logger.LogInformation($"{hotel.MealsTypes[1].PricePerDay}");
            Logger.LogInformation($"{hotel.MealsTypes[2].PricePerDay}");
            Logger.LogInformation($"{hotel.MealsTypes[3].PricePerDay}");
            Logger.LogInformation($"{hotel.MealsTypes[4].PricePerDay}");
            Logger.LogInformation($"{hotel.MealsTypes[5].PricePerDay}");
            Logger.LogInformation($"{hotel.MealsTypes[6].PricePerDay}");
            Logger.LogInformation($"{hotel.MealsTypes[7].PricePerDay}");

            return View(lodging);
        }

        [HttpPost]
        public void Reservation(ReservationViewModel reservation)
        {
            Logger.LogInformation($"{reservation.MealsType.FoodType}");
            Logger.LogInformation($"{reservation.TimePeriod.Start}");
            Logger.LogInformation($"{reservation.TimePeriod.End}");
            Logger.LogInformation($"{reservation.PricePerNight}");
            Logger.LogInformation($"{reservation.TotalPrice}");
        }

    }
}
