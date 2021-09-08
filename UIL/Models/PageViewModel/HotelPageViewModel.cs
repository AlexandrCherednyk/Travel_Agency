using System.Collections.Generic;

namespace UIL.Models.PageViewModel
{
    public class HotelPageViewModel
    {
        public IEnumerable<HotelViewModel> Hotels { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
