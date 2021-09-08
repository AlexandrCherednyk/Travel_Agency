using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIL.Models.PageViewModel
{
    public class LodgingPageViewModel
    {
        public HotelViewModel Hotel { get; set; }
        public IEnumerable<LodgingViewModel> Lodgings { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
