using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
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

        public IActionResult Test()
        {
            //string pathToFirstImage = @"~/HotelImages/1.jpg";
            //string pathToSecondImage = @"~/HotelImages/2.jpg";
            //string pathToThirdImage = @"~/HotelImages/3.jpg";

            //string lodgingPathToFirstImage = @"~/LodgingImages/1.jpg";
            //string lodgingPathToSecondImage = @"~/LodgingImages/2.jpg";

            //HotelViewModel hotel = new HotelViewModel("Ukraine", "USA", StarRating.Starless, pathToThirdImage);
            //hotel.MaxLodgingPrice = 0;
            //hotel.MinLodgingPrice = 0;

            //for (int counter = 0; counter < 5; counter++)
            //{
            //    var guestRoom = new GuestRoomViewModel(3, RoomCategory.Luxe, 1000, 100, 1, 0, lodgingPathToSecondImage);

            //    var start = new DateTime(2021, 9, 24);
            //    var end = new DateTime(2021, 9, 28);
            //    var mealsType = new MealsTypeViewModel();
            //    var reservation = new ReservationViewModel(new TimePeriodViewModel(start, end), mealsType, guestRoom.PricePerNight);

            //    guestRoom.Reservations.Add(reservation);

            //    hotel.Lodgings.Add(guestRoom);
            //}

            //HotelService.Add(Mapper.Map<HotelDTO>(hotel));

            var hotel = Mapper.Map<HotelViewModel>(HotelService.GetHotelByGuId(new Guid("72f92f80-1638-4cd0-b0e4-7c33e6ec7fe0")));
            hotel.Name = "Hotel";
            HotelService.Update(Mapper.Map<HotelDTO>(hotel), new Guid("72f92f80-1638-4cd0-b0e4-7c33e6ec7fe0"));

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
