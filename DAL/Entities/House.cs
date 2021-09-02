using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public enum HouseType
    {
        Сottage,
        Villa,
        Bungalow
    }

    public class House : Lodging
    {
        public int FloorsNumber { get; set; }
        public int RoomsNumber { get; set; }
        public HouseType Type { get; set; }

        public House() { }
        public House(int floorsNumber, int roomsNumber, HouseType type, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(pricePerNight, area, adultGuests, childrenGuests)
        {
            FloorsNumber = floorsNumber;
            RoomsNumber = roomsNumber;
            Type = type;
        }
    }
}
