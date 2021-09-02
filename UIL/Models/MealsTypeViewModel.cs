using System;
namespace UIL.Models
{
    public enum FoodType
    {
        OnlyBed, // Без пропитания.
        BedAndBreakfast, // Завтрак.
        HalfBoard, // Завтрак и ужин.
        HalfBoardPlus, // Завтрак и ужин + алкогольные напитки местного производства.
        FullBoard, // Завтрак, обед и ужин.
        FullBoardPlus, // Завтрак, обед и ужин + алкогольные напитки.
        AllInclusive, // Завтрак, обед и ужин + алкогольные и безалкогольные напитки + доп. питание.
        UltraAllInclusive // Завтрак, обед и ужин + различные напитки в неограниченом кол. + доп. питание.
    }
    public class MealsTypeViewModel
    {
        public FoodType FoodType { get; set; }
        public decimal PricePerDay { get; set; }

        public MealsTypeViewModel()
        {
            FoodType = FoodType.OnlyBed;
            PricePerDay = 0;
            
        }
        public MealsTypeViewModel(FoodType mealsType, decimal pricePerDay)
        {
            FoodType = mealsType;
            PricePerDay = pricePerDay;
        }

        public decimal GetMealsTypePriceInFewDays (int daysNumber)
        {
            return PricePerDay * daysNumber;
        }

        public override string ToString()
        {
            return $"Meals type: {FoodType}; Price per day: {PricePerDay}.";
        }
    }
}
