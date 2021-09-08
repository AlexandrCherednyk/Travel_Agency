using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public enum FacilitiesType
    {
        Conditioner,
        Bathroom,
        Kettle
    }
    public abstract class Lodging
    {
        [Key]
        public int DbId { get; set; }
        public Guid Id { get; set; }
        public decimal PricePerNight { get; set; }
        public double Area { get; set; }
        public int AdultGuests { get; set; }
        public int ChildrenGuests { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public string PathToImage { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }

        public Lodging() 
        {
            Reservations = new HashSet<Reservation>();
        }
        public Lodging(decimal pricePerNight, double area, int adultGuests, int childrenGuests)
        {
            Id = Guid.NewGuid();
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new HashSet<Reservation>();
        }
        public Lodging(decimal pricePerNight, double area, int adultGuests, int childrenGuests, string pathToImage)
        {
            Id = Guid.NewGuid();
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new HashSet<Reservation>();
            PathToImage = pathToImage;
        }
    }
}
