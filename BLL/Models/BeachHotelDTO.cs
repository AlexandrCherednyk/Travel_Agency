using System;
using System.Collections.Generic;

namespace BLL.Models
{
    public enum DistanceFromTheSea
    {
        FirstCoastline,
        SecondCoastline,
        ThirdCoastline
    }
    public class BeachHotelDTO : HotelDTO
    {
        public DistanceFromTheSea DistanceFromTheSea { get; set; }

        public BeachHotelDTO(DistanceFromTheSea distanceFromTheSea, string name, string country, StarCategory starCategory) : base(name, country, starCategory)
        {
            DistanceFromTheSea = distanceFromTheSea;
        }
        public BeachHotelDTO(DistanceFromTheSea distanceFromTheSea, string name, string country, StarCategory starCategory, List<LodgingDTO> lodgings) : base(name, country, starCategory, lodgings)
        {
            DistanceFromTheSea = distanceFromTheSea;
        }
        public BeachHotelDTO(DistanceFromTheSea distanceFromTheSea, Guid id, string name, string country, StarCategory starCategory, List<LodgingDTO> lodgings) : base(id, name, country, starCategory, lodgings)
        {
            DistanceFromTheSea = distanceFromTheSea;
        }
    }
}
