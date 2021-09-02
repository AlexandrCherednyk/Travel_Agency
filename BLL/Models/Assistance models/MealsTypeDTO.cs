using System;
namespace BLL.Models.Assistance_models
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
    public class MealsTypeDTO
    {
        public FoodType FoodType { get; set; }
        public decimal PricePerDay { get; set; }
        public MealsTypeDTO() { }
        public MealsTypeDTO(FoodType mealsType, decimal pricePerDay)
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
