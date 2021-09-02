using System;
using System.Collections.Generic;

namespace UIL.Models
{
    public enum RoomCategory
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

    public class GuestRoomViewModel : LodgingViewModel
    {
        public int RoomsNumber { get; set; }
        public RoomCategory Category { get; set; }

        public GuestRoomViewModel() { }
        public GuestRoomViewModel(int roomsNumber, RoomCategory roomCategory, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(pricePerNight, area, adultGuests, childrenGuests)
        {
            RoomsNumber = roomsNumber;
            Category = roomCategory;
        }

        public GuestRoomViewModel(int roomsNumber, RoomCategory roomCategory, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(id, pricePerNight, area, adultGuests, childrenGuests)
        {
            RoomsNumber = roomsNumber;
            Category = roomCategory;
        }

        public GuestRoomViewModel(int roomsNumber, RoomCategory roomCategory, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationViewModel> reservations) : base(pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            RoomsNumber = roomsNumber;
            Category = roomCategory;
        }
        public GuestRoomViewModel(int roomsNumber, RoomCategory roomCategory, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationViewModel> reservations) : base(id, pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            RoomsNumber = roomsNumber;
            Category = roomCategory;
        }
    }
}
