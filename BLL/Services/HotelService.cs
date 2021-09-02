using AutoMapper;
using BLL.Interfaces;
using BLL.Models;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class HotelService : IHotelService
    {
        private IUnitOfWork Database { get; set; }
        private readonly IMapper Mapper;
        public HotelService(IMapper mapper)
        {
            Mapper = mapper;
            Database = new UnitOfWork();
        }
        public void Add(HotelDTO hotelDTO)
        {
            var hotel = Mapper.Map<Hotel>(hotelDTO);
            Database.HotelRepository.Create(hotel);
            Database.Save();
        }

        public HotelDTO GetHotelByDbId(int id)
        {
            var DALHotel = Database.HotelRepository.GetByDbId(id);
            var hotel = Mapper.Map<HotelDTO>(DALHotel);
            return hotel;
        }
        public HotelDTO GetHotelByGuId(Guid id)
        {
            var DALHotel = Database.HotelRepository.GetByGuId(id);
            var hotel = Mapper.Map<HotelDTO>(DALHotel);
            return hotel;
        }
        public List<HotelDTO> GetHotelList()
        {
            var DALHotels = Database.HotelRepository.GetAll().ToList();
            var hotels = Mapper.Map<List<HotelDTO>>(DALHotels);
            return hotels;
        }

        public void Update(HotelDTO hotelDTO)
        {
            var hotel = Mapper.Map<Hotel>(hotelDTO);
            Database.HotelRepository.Update(hotel);
            Database.Save();
        }

        public void Update(HotelDTO hotelDTO, Guid id)
        {
            var hotel = Mapper.Map<Hotel>(hotelDTO);
            Database.HotelRepository.Update(hotel);
            Database.Save();
        }

        public void DeleteByDbId(int id)
        {
            Database.HotelRepository.DeleteByDbId(id);
            Database.Save();
        }

        public void DeleteByGuId(Guid id)
        {
            Database.HotelRepository.DeleteByGuid(id);
            Database.Save();
        }
    }
}
