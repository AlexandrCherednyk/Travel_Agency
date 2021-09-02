using BLL.Models;
using BLL.Models.Assistance_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ITestService
    {
        TimePeriodDTO GetTimePeriod();
        GuestRoomDTO GetGuestRoom();
        IEnumerable<HotelDTO> GetHotelList();
    }
}
