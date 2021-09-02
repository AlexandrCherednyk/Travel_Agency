using BLL.Models.Assistance_models;
using System;

namespace BLL.Models
{
    public class ReservationDTO
    {
        public Guid Id { get; set; }
        //public AuthorizedUser User { get; set; }
        public TimePeriodDTO TimePeriod { get; set; }
        public MealsTypeDTO MealsType { get; set; }
        public decimal PricePerNight { get; set; }
        public decimal TotalPrice { get; set; }
        public ReservationDTO() { }
        public ReservationDTO(TimePeriodDTO timePeriod, MealsTypeDTO mealsType, decimal pricePerNight)
        {
            Id = Guid.NewGuid();
            TimePeriod = timePeriod;
            MealsType = mealsType;
            PricePerNight = pricePerNight;

            CalculateTotalPrice();
        }
        public ReservationDTO(Guid id, TimePeriodDTO timePeriod, MealsTypeDTO mealsType, decimal pricePerNight, decimal totalPrice)
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

        internal bool IsDeprecated()
        {
            if(TimePeriod.End < DateTime.Now)
            {
                return true;
            }

            return false;
        }
    }
}
