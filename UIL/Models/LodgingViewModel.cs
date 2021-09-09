using System;
using System.Collections.Generic;

namespace UIL.Models
{
    public enum Facilities
    {
        Conditioner,
        Bathroom,
        Kettle
    }
    public abstract class LodgingViewModel
    {
        public Guid Id { get; set; }
        public decimal PricePerNight { get; set; }
        public double Area { get; set; }
        public int AdultGuests { get; set; }
        public int ChildrenGuests { get; set; }
        public List<ReservationViewModel> Reservations { get; set; }
        public string PathToImage { get; set; }

        public LodgingViewModel() { }
        public LodgingViewModel(decimal pricePerNight, double area, int adultGuests, int childrenGuests)
        {
            Id = Guid.NewGuid();
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new List<ReservationViewModel>();
        }
        public LodgingViewModel(decimal pricePerNight, double area, int adultGuests, int childrenGuests, string pathToImage)
        {
            Id = Guid.NewGuid();
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new List<ReservationViewModel>();
            PathToImage = pathToImage;
        }
        public LodgingViewModel(Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests)
        {
            Id = id;
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new List<ReservationViewModel>();
        }
        public LodgingViewModel(decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationViewModel> reservations)
        {
            Id = Guid.NewGuid();
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new List<ReservationViewModel>(reservations);
        }
        public LodgingViewModel(Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationViewModel> reservations)
        {
            Id = id;
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new List<ReservationViewModel>(reservations);
        }


    }
}
