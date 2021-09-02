using System;
using System.Collections.Generic;

namespace BLL.Models
{
    public enum ApartamentType
    {
        A,
        B,
        C,
        Luxe
    }

    public class ApartamentsDTO : LodgingDTO
    {
        public int RoomsNumber { get; set; }
        public ApartamentType Type { get; set; }

        public ApartamentsDTO(int roomsNumber, ApartamentType type, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(pricePerNight, area, adultGuests, childrenGuests)
        {
            RoomsNumber = roomsNumber;
            Type = type;
        }

        public ApartamentsDTO(int roomsNumber, ApartamentType type, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests) : base(id, pricePerNight, area, adultGuests, childrenGuests)
        {
            RoomsNumber = roomsNumber;
            Type = type;
        }

        public ApartamentsDTO(int roomsNumber, ApartamentType type, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationDTO> reservations) : base(pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            RoomsNumber = roomsNumber;
            Type = type;
        }
        public ApartamentsDTO(int roomsNumber, ApartamentType type, Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationDTO> reservations) : base(id, pricePerNight, area, adultGuests, childrenGuests, reservations)
        {
            RoomsNumber = roomsNumber;
            Type = type;
        }
    }
}
