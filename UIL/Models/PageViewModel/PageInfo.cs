using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIL.Models.PageViewModel
{
    public class PageInfo
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { 
            get { return (int)Math.Ceiling((decimal)TotalItems / PageSize); }
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPages);
            }
        }
    }
}
