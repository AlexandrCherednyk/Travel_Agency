using System.Collections.Generic;

namespace UIL.Models.PageViewModel
{
    public class LodgingPageViewModel
    {
        public HotelViewModel Hotel { get; set; }
        public IEnumerable<LodgingViewModel> Lodgings { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
