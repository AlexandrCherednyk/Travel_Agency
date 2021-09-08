using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UIL.Models;

namespace UIL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> Logger;
        private readonly IMapper Mapper;

        private readonly IHotelService HotelService;

        public HomeController(ILogger<HomeController> logger, IMapper mapper, IHotelService hotelService)
        {
            Logger = logger;
            Mapper = mapper;
            HotelService = hotelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public void Test()
        {
            //Logger.LogTrace("fuck");
            string pathToFirstImage = @"~/HotelImages/1.jpg";
            string pathToSecondImage = @"~/HotelImages/2.jpg";
            string pathToThirdImage = @"~/HotelImages/3.jpg";

            HotelViewModel hotel = new HotelViewModel("Ukraine", "USA", StarRating.ThreeStars, pathToFirstImage);

            var guestRoom = new GuestRoomViewModel(3, RoomCategory.Luxe, 1000, 100, 1, 0);

            var start = new DateTime(2001, 9, 24);
            var end = new DateTime(2001, 9, 28);
            var mealsType = new MealsTypeViewModel();
            var reservation = new ReservationViewModel(new TimePeriodViewModel(start, end), mealsType, guestRoom.PricePerNight);

            guestRoom.Reservations.Add(reservation);

            hotel.Lodgings.Add(guestRoom);

            HotelService.Add(Mapper.Map<HotelDTO>(hotel));
            
            //return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
