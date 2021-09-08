using BLL.Models.Assistance_models;
using System;
using System.Collections.Generic;

namespace BLL.Models
{
    public enum Facilities
    {
        Conditioner,
        Bathroom,
        Kettle
    }
    public abstract class LodgingDTO
    {
        public Guid Id { get; set; }
        public decimal PricePerNight { get; set; }
        public double Area { get; set; }
        public int AdultGuests { get; set; }
        public int ChildrenGuests { get; set; }
        public List<ReservationDTO> Reservations { get; set; }
        public string PathToImage { get; set; }
        public LodgingDTO() { }
        public LodgingDTO(decimal pricePerNight, double area, int adultGuests, int childrenGuests)
        {
            Id = Guid.NewGuid();
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new List<ReservationDTO>();
        }
        public LodgingDTO(decimal pricePerNight, double area, int adultGuests, int childrenGuests, string pathToImage)
        {
            Id = Guid.NewGuid();
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new List<ReservationDTO>();
            PathToImage = pathToImage;
        }
        public LodgingDTO(Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests)
        {
            Id = id;
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new List<ReservationDTO>();
        }
        public LodgingDTO(decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationDTO> reservations)
        {
            Id = Guid.NewGuid();
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new List<ReservationDTO>(reservations);
        }
        public LodgingDTO(Guid id, decimal pricePerNight, double area, int adultGuests, int childrenGuests, List<ReservationDTO> reservations)
        {
            Id = id;
            PricePerNight = pricePerNight;
            Area = area;
            AdultGuests = adultGuests;
            ChildrenGuests = childrenGuests;
            Reservations = new List<ReservationDTO>(reservations);
        }

        //public void OnNewDay(object sender, EventArgs e)
        //{
        //    for(int counter=0; counter < Reservations.Count; counter++) 
        //    {
        //        if (Reservations[counter].IsDeprecated())
        //        {
        //            Reservations.RemoveAt(counter);
        //            counter--;
        //        }
        //    }
        //}
    }
}
