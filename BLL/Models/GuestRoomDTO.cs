using System;
using System.Collections.Generic;

namespace BLL.Models
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

    public class GuestRoomDTO : LodgingDTO
    {
        public int RoomsNumber { get; set; }
        public HotelRoomCategory Category { get; set; }
        public GuestRoomDTO() { }
        public GuestRoomDTO(int roomsNumber, HotelRoomCategory roomCategory, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(pricePerNight, area, adultGuests, childrenGuests)
        {
            RoomsNumber = roomsNumber;
            Category = roomCategory;
        }

        public GuestRoomDTO(int roomsNumber, HotelRoomCategory roomCategory, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(id, pricePerNight, area, adultGuests, childrenGuests)
        {
            RoomsNumber = roomsNumber;
            Category = roomCategory;
        }

        public GuestRoomDTO(int roomsNumber, HotelRoomCategory roomCategory, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationDTO> reservations) : base(pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            RoomsNumber = roomsNumber;
            Category = roomCategory;
        }
        public GuestRoomDTO(int roomsNumber, HotelRoomCategory roomCategory, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationDTO> reservations) : base(id, pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            RoomsNumber = roomsNumber;
            Category = roomCategory;
        }
    }
}
