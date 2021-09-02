using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Reservation
    {
        [Key]
        public int DbId { get; set; }
        public Guid Id { get; set; }
        public virtual TimePeriod TimePeriod { get; set; }
        public virtual MealsType MealsType { get; set; }
        public decimal PricePerNight { get; set; }
        public decimal TotalPrice { get; set; }
        public int LodgingId { get; set; }
        public virtual Lodging Lodging { get; set; }
        public Reservation() { }
        public Reservation(TimePeriod timePeriod, MealsType mealsType, decimal pricePerNight)
        {
            Id = Guid.NewGuid();
            TimePeriod = timePeriod;
            MealsType = mealsType;
            PricePerNight = pricePerNight;

            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            TotalPrice = PricePerNight * TimePeriod.GetNightsNumber() + MealsType.PricePerDay * TimePeriod.GetNightsNumber();
        }
    }
}
