using AutoMapper;
using BLL.Models;
using BLL.Models.Assistance_models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappings
{
    public class BL_MappingProfile : Profile
    {
        public BL_MappingProfile()
        {
            CreateMap<Hotel, HotelDTO>()
                .Include<BeachHotel, BeachHotelDTO>()
                .ReverseMap();

            CreateMap<BeachHotel, BeachHotelDTO>()
                .ReverseMap();

            CreateMap<Lodging, LodgingDTO>()
                .Include<Apartaments, ApartamentsDTO>()
                .Include<House, HouseDTO>()
                .Include<GuestRoom, GuestRoomDTO>()
                .ReverseMap();

            CreateMap<Apartaments, ApartamentsDTO>()
                .ReverseMap();
            CreateMap<House, HouseDTO>()
                .ReverseMap();
            CreateMap<GuestRoom, GuestRoomDTO>()
                .ReverseMap();

            CreateMap<Reservation, ReservationDTO>()
                .ReverseMap();
            CreateMap<TimePeriod, TimePeriodDTO>()
                .ReverseMap();
            CreateMap<MealsType, MealsTypeDTO>()
                .ReverseMap();
        }
    }
}
