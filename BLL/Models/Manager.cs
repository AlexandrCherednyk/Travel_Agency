using System.Collections.Generic;
namespace BLL.Models
{
    public sealed class Manager : AuthorizedUser
    {
        public Manager(string email, string password) : base(email, password)
        {
        }

        public Manager(string email, string password, string firstName, string secondName, string phoneNumber) : base(email, password, firstName, secondName, phoneNumber)
        {
        }

        //public override List<Hotel> GetHotelsList()
        //{
        //    return HotelsList.GetHotelsList();
        //}
    }
}
