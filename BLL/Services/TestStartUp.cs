using BLL.Interfaces;
using BLL.Models;
using BLL.Models.Assistance_models;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
    public class TestStartUp : ITestService
    {
        public List<HotelDTO> Hotels;
        public TimePeriodDTO TimePeriod;
        public GuestRoomDTO GuestRoom;

        public TestStartUp()
        {
            Hotels = new List<HotelDTO>();

            AddHotel();
        }

        public GuestRoomDTO GetGuestRoom()
        {
            return GuestRoom;
        }

        public IEnumerable<HotelDTO> GetHotelList()
        {
            return Hotels;
        }

        public TimePeriodDTO GetTimePeriod()
        {
            return TimePeriod;
        }

        private void AddHotel()
        {
            var hotel = new HotelDTO("Ukraine", "USA", StarCategory.FiveStars);

            var guestRoom = new GuestRoomDTO(3, HotelRoomCategory.Luxe, 1000, 100, 1, 0);

            var start = new DateTime(2001, 9, 24);
            var end = new DateTime(2001, 9, 28);
            var mealsType = new MealsTypeDTO();
            var reservation = new ReservationDTO(new TimePeriodDTO(start, end), mealsType, guestRoom.PricePerNight);

            guestRoom.Reservations.Add(reservation);

            hotel.Lodgings.Add(guestRoom);

            TimePeriod = new TimePeriodDTO(start, end);
            GuestRoom = guestRoom;
            Hotels.Add(hotel);
        }
    }
}
