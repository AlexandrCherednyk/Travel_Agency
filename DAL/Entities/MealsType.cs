using Microsoft.EntityFrameworkCore;

namespace DAL.Entities
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
    [Owned]
    public class MealsType
    {
        public FoodType FoodType { get; set; }
        public decimal PricePerDay { get; set; }

        public MealsType() { }
    }
}
