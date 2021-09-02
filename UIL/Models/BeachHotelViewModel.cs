using System;
using System.Collections.Generic;

namespace UIL.Models
{
    public enum DistanceFromTheSea
    {
        FirstCoastline,
        SecondCoastline,
        ThirdCoastline
    }
    public class BeachHotelViewModel : HotelViewModel
    {
        public DistanceFromTheSea DistanceFromTheSea { get; set; }

        public BeachHotelViewModel(DistanceFromTheSea distanceFromTheSea, string name, string country, StarRating starCategory) : base(name, country, starCategory)
        {
            DistanceFromTheSea = distanceFromTheSea;
        }
        public BeachHotelViewModel(DistanceFromTheSea distanceFromTheSea, string name, string country, StarRating starCategory, List<LodgingViewModel> lodgings) : base(name, country, starCategory, lodgings)
        {
            DistanceFromTheSea = distanceFromTheSea;
        }
        public BeachHotelViewModel(DistanceFromTheSea distanceFromTheSea, Guid id, string name, string country, StarRating starCategory, List<LodgingViewModel> lodgings) : base(id, name, country, starCategory, lodgings)
        {
            DistanceFromTheSea = distanceFromTheSea;
        }
    }
}
