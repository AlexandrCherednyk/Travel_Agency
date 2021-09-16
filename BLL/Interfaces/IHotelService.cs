using BLL.Models;
using System;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IHotelService// : IDisposable
    {
        List<HotelDTO> GetHotelList();
        HotelDTO GetHotelByGuId(Guid id);
        //IEnumerable<HotelDTO> GetHotelListByName(string name);
        //IEnumerable<HotelDTO> GetHotelListByCountry(string country);
        //IEnumerable<HotelDTO> GetHotelListByStarRating(StarCategory starRating);
        void Add(HotelDTO hotelDTO);
        void Update(HotelDTO hotelDTO);
        void DeleteByGuId(Guid id);
    }
}
