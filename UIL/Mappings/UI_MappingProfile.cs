using AutoMapper;
using BLL.Models;
using BLL.Models.Assistance_models;
using UIL.Models;

namespace UIL.Mappings
{
    public class UI_MappingProfile : Profile
    {
        public UI_MappingProfile()
        {
            CreateMap<HotelDTO, HotelViewModel>()
                .Include<BeachHotelDTO, BeachHotelViewModel>()
                .ReverseMap();

            CreateMap<BeachHotelDTO, BeachHotelViewModel>()
                .ReverseMap();

            CreateMap<LodgingDTO, LodgingViewModel>()
                .Include<ApartamentsDTO, ApartamentsViewModel>()
                .Include<HouseDTO, HouseViewModel>()
                .Include<GuestRoomDTO, GuestRoomViewModel>()
                .ReverseMap();

            CreateMap<ApartamentsDTO, ApartamentsViewModel>()
                .ReverseMap();
            CreateMap<HouseDTO, HouseViewModel>()
                .ReverseMap();
            CreateMap<GuestRoomDTO, GuestRoomViewModel>()
                .ReverseMap();

            CreateMap<ReservationDTO, ReservationViewModel>()
                .ReverseMap();
            CreateMap<TimePeriodDTO, TimePeriodViewModel>()
                .ReverseMap();
            CreateMap<MealsTypeDTO, MealsTypeViewModel>()
                .ReverseMap();
        }
    }
}
