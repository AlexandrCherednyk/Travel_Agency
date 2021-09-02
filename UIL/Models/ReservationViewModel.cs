using System;

namespace UIL.Models
{
    public class ReservationViewModel
    {
        public Guid Id { get; set; }
        //public AuthorizedUser User { get; set; }
        public TimePeriodViewModel TimePeriod { get; set; }
        public MealsTypeViewModel MealsType { get; set; }
        public decimal PricePerNight { get; set; }
        public decimal TotalPrice { get; set; }
        
        public ReservationViewModel(TimePeriodViewModel timePeriod, MealsTypeViewModel mealsType, decimal pricePerNight)
        {
            Id = Guid.NewGuid();
            TimePeriod = timePeriod;
            MealsType = mealsType;
            PricePerNight = pricePerNight;

            CalculateTotalPrice();
        }
        public ReservationViewModel(Guid id, TimePeriodViewModel timePeriod, MealsTypeViewModel mealsType, decimal pricePerNight, decimal totalPrice)
        {
            Id = id;
            TimePeriod = timePeriod;
            MealsType = mealsType;
            PricePerNight = pricePerNight;
            TotalPrice = totalPrice;
        }

        private void CalculateTotalPrice()
        {
            TotalPrice = PricePerNight * TimePeriod.GetNightsNumber() + MealsType.PricePerDay * TimePeriod.GetNightsNumber();
        }
    }
}
