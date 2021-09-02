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

        public HotelViewModel() { }
        public HotelViewModel(string name, string country, StarRating starCategory)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingViewModel>();
        }
        public HotelViewModel(string name, string country, StarRating starCategory, List<LodgingViewModel> lodgings)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingViewModel>(lodgings);
        }
        public HotelViewModel(Guid id, string name, string country, StarRating starCategory, List<LodgingViewModel> lodgings)
        {
            Id = id;
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingViewModel>(lodgings);
        }
    }
}
