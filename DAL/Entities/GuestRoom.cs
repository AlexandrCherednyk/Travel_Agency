using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public enum HotelRoomCategory
    {
        Standart,
        Economy,
        Luxe,
        Business,
        Duplex,
        Studio, 
        FamilyRoom,
        Another
    }

    public class GuestRoom : Lodging
    {
        public int RoomsNumber { get; set; }
        public HotelRoomCategory Category { get; set; }

        public GuestRoom() { }
        public GuestRoom(int roomsNumber, HotelRoomCategory roomCategory, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(pricePerNight, area, adultGuests, childrenGuests)
        {
            RoomsNumber = roomsNumber;
            Category = roomCategory;
        }
    }
}
