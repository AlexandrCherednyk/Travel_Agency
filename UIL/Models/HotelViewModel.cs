using System;
using System.Collections.Generic;

namespace UIL.Models
{
    public enum StarRating
    {
        Starless,
        OneStar,
        TwoStars,
        ThreeStars,
        FourStars,
        FiveStars
    }

    public class HotelViewModel
    {
        public Guid Id { get;  set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public StarRating StarRating { get; set; }
        public List<LodgingViewModel> Lodgings { get; set; }
        public List<MealsTypeViewModel> MealsTypes { get; set; }
        public string PathToImage { get; set; }
        public decimal MaxLodgingPrice { get; set; }
        public decimal MinLodgingPrice { get; set; }

        public HotelViewModel() { }
        public HotelViewModel(string name, string country, StarRating starCategory)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingViewModel>();
            MealsTypes = new List<MealsTypeViewModel>();

            InitilizeMealsTypeArray();
        }
        public HotelViewModel(string name, string country, StarRating starCategory, string pathToImage)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingViewModel>();
            MealsTypes = new List<MealsTypeViewModel>();
            PathToImage = pathToImage;

            InitilizeMealsTypeArray();
        }
        public HotelViewModel(string name, string country, StarRating starCategory, List<LodgingViewModel> lodgings)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingViewModel>(lodgings);
            MealsTypes = new List<MealsTypeViewModel>();

            InitilizeMealsTypeArray();
        }
        public HotelViewModel(Guid id, string name, string country, StarRating starCategory, List<LodgingViewModel> lodgings)
        {
            Id = id;
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingViewModel>(lodgings);
            MealsTypes = new List<MealsTypeViewModel>();

            InitilizeMealsTypeArray();
        }

        private void InitilizeMealsTypeArray()
        {
            MealsTypes.Add(new MealsTypeViewModel() { PricePerDay = 1, FoodType = FoodType.OnlyBed });
            MealsTypes.Add(new MealsTypeViewModel() { PricePerDay = 2, FoodType = FoodType.BedAndBreakfast });
            MealsTypes.Add(new MealsTypeViewModel() { PricePerDay = 3, FoodType = FoodType.HalfBoard });
            MealsTypes.Add(new MealsTypeViewModel() { PricePerDay = 4, FoodType = FoodType.HalfBoardPlus });
            MealsTypes.Add(new MealsTypeViewModel() { PricePerDay = 5, FoodType = FoodType.FullBoard });
            MealsTypes.Add(new MealsTypeViewModel() { PricePerDay = 6, FoodType = FoodType.FullBoardPlus });
            MealsTypes.Add(new MealsTypeViewModel() { PricePerDay = 7, FoodType = FoodType.AllInclusive });
            MealsTypes.Add(new MealsTypeViewModel() { PricePerDay = 8, FoodType = FoodType.UltraAllInclusive });
        }
    }
}
