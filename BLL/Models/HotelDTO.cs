using System;
using System.Collections.Generic;
using System.Linq;

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
        public string PathToImage { get; set; }
        public decimal MaxLodgingPrice
        { 
            get
            {
                return Lodgings.OrderBy(l => l.PricePerNight)
                    .First().PricePerNight;
            }
        }
        public decimal MinLodgingPrice
        {
            get
            {
                return Lodgings.OrderByDescending(l => l.PricePerNight)
                    .First().PricePerNight;
            }
        }

        public HotelDTO() { }
        public HotelDTO(string name, string country, StarCategory starCategory)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingDTO>();
        }
        public HotelDTO(string name, string country, StarCategory starCategory, string pathToImage)
        {
            Id = Guid.NewGuid();
            Name = name;
            Country = country;
            StarRating = starCategory;
            Lodgings = new List<LodgingDTO>();
            PathToImage = pathToImage;
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
