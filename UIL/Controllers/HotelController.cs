using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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

            ReservationPageViewModel reservationPageViewModel = new ReservationPageViewModel() { Hotel = hotel, Lodging = lodging };

            return View(reservationPageViewModel);
        }

        [HttpPost]
        public ActionResult Reservation(string dates, FoodType foodType, Guid hotelId, Guid lodgingId)
        {
            var hotel = Hotels.First(h => h.Id == hotelId);
            var lodging = hotel.Lodgings.First(l => l.Id == lodgingId);

            if (hotel == null)
            {
            }

            string[] subDates = dates.Split("-");
            string trimStar = subDates[0].Trim();
            string trimEnd = subDates[1].Trim();

            string[] subStar = trimStar.Split("/");
            string[] subEnd = trimEnd.Split("/");

            DateTime start = new(int.Parse(subStar[2].TrimStart('0')), int.Parse(subStar[0].TrimStart('0')), int.Parse(subStar[1]));
            DateTime end = new(int.Parse(subEnd[2].TrimStart('0')), int.Parse(subEnd[0].TrimStart('0')), int.Parse(subEnd[1]));

            decimal pricePerDay = 0;

            foreach (MealsTypeViewModel mealsTypeViewModel in hotel.MealsTypes)
            {
                if (mealsTypeViewModel.FoodType == foodType)
                {
                    pricePerDay = mealsTypeViewModel.PricePerDay;
                    break;
                }
            }

            TimePeriodViewModel timePeriod = new TimePeriodViewModel(start, end);
            MealsTypeViewModel mealsType = new MealsTypeViewModel(foodType, pricePerDay);

            ReservationViewModel reservation = new ReservationViewModel(timePeriod, mealsType, lodging.PricePerNight);

            foreach (ReservationViewModel res in lodging.Reservations)
            {
                if (TimePeriodViewModel.IsInterset(reservation.TimePeriod, res.TimePeriod))
                {
                    return RedirectToAction("Reservation", new { hotelId = hotel.Id, lodgingId = lodging.Id });
                }
            }

            lodging.Reservations.Add(reservation);
            HotelService.Update(Mapper.Map<HotelDTO>(hotel));

            return View("SuccessfulReservation");
        }
    }
}
