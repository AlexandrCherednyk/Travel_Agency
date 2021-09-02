using System;
using System.Collections.Generic;

namespace BLL.Models
{
    public enum HouseType
    {
        Сottage,
        Villa,
        Bungalow
    }

    public class HouseDTO : LodgingDTO
    {
        public int FloorsNumber { get; set; }
        public int RoomsNumber { get; set; }
        public HouseType Type { get; set; }

        public HouseDTO(int floorsNumber, int roomsNumber, HouseType type, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(pricePerNight, area, adultGuests, childrenGuests)
        {
            FloorsNumber = floorsNumber;
            RoomsNumber = roomsNumber;
            Type = type;
        }

        public HouseDTO(int floorsNumber, int roomsNumber, HouseType type, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(id, pricePerNight, area, adultGuests, childrenGuests)
        {
            FloorsNumber = floorsNumber;
            RoomsNumber = roomsNumber;
            Type = type;
        }

        public HouseDTO(int floorsNumber, int roomsNumber, HouseType type, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationDTO> reservations) : base(pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            FloorsNumber = floorsNumber;
            RoomsNumber = roomsNumber;
            Type = type;
        }
        public HouseDTO(int floorsNumber, int roomsNumber, HouseType type, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationDTO> reservations) : base(id, pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            FloorsNumber = floorsNumber;
            RoomsNumber = roomsNumber;
            Type = type;
        }
    }
}
