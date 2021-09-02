using System;
using System.Collections.Generic;

namespace BLL.Models
{
    public enum StarCategory
    {
        Starless,
        OneStar,
        TwoStars,
        ThreeStars,
        FourStars,
        FiveStars
    }

    public class HotelDTO
    {
        public Guid Id { get;  set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public StarCategory StarRating { get; set; }
        public List<LodgingDTO> Lodgings { get; set; }
        public HotelDTO() { }
        public HotelDTO(string name, string country, StarCategory starCategory)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingDTO>();
        }
        public HotelDTO(string name, string country, StarCategory starCategory, List<LodgingDTO> lodgings)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingDTO>(lodgings);
        }
        public HotelDTO(Guid id, string name, string country, StarCategory starCategory, List<LodgingDTO> lodgings)
        {
            Id = id;
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingDTO>(lodgings);
        }
    }
}
