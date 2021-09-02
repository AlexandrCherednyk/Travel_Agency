using System;
using System.Collections.Generic;

namespace UIL.Models
{
    public enum ApartamentType
    {
        A,
        B,
        C,
        Luxe
    }

    public class ApartamentsViewModel : LodgingViewModel
    {
        public int RoomsNumber { get; set; }
        public ApartamentType Type { get; set; }

        public ApartamentsViewModel() { }
        public ApartamentsViewModel(int roomsNumber, ApartamentType type, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(pricePerNight, area, adultGuests, childrenGuests)
        {
            RoomsNumber = roomsNumber;
            Type = type;
        }

        public ApartamentsViewModel(int roomsNumber, ApartamentType type, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(id, pricePerNight, area, adultGuests, childrenGuests)
        {
            RoomsNumber = roomsNumber;
            Type = type;
        }

        public ApartamentsViewModel(int roomsNumber, ApartamentType type, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationViewModel> reservations) : base(pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            RoomsNumber = roomsNumber;
            Type = type;
        }
        public ApartamentsViewModel(int roomsNumber, ApartamentType type, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationViewModel> reservations) : base(id, pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            RoomsNumber = roomsNumber;
            Type = type;
        }
    }
}
