using System;
using System.Collections.Generic;

namespace UIL.Models
{
    public enum HouseType
    {
        Сottage,
        Villa,
        Bungalow
    }

    public class HouseViewModel : LodgingViewModel
    {
        public int FloorsNumber { get; set; }
        public int RoomsNumber { get; set; }
        public HouseType Type { get; set; }

        public HouseViewModel() { }
        public HouseViewModel(int floorsNumber, int roomsNumber, HouseType type, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(pricePerNight, area, adultGuests, childrenGuests)
        {
            FloorsNumber = floorsNumber;
            RoomsNumber = roomsNumber;
            Type = type;
        }
        public HouseViewModel(int floorsNumber, int roomsNumber, HouseType type, decimal pricePerNight, double area, int adultGuests, int childrenGuests, string pathToImage) : base(pricePerNight, area, adultGuests, childrenGuests, pathToImage)
        {
            FloorsNumber = floorsNumber;
            RoomsNumber = roomsNumber;
            Type = type;
        }

        public HouseViewModel(int floorsNumber, int roomsNumber, HouseType type, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(id, pricePerNight, area, adultGuests, childrenGuests)
        {
            FloorsNumber = floorsNumber;
            RoomsNumber = roomsNumber;
            Type = type;
        }

        public HouseViewModel(int floorsNumber, int roomsNumber, HouseType type, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationViewModel> reservations) : base(pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            FloorsNumber = floorsNumber;
            RoomsNumber = roomsNumber;
            Type = type;
        }
        public HouseViewModel(int floorsNumber, int roomsNumber, HouseType type, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationViewModel> reservations) : base(id, pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            FloorsNumber = floorsNumber;
            RoomsNumber = roomsNumber;
            Type = type;
        }
    }
}
