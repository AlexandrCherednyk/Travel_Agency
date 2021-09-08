using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIL.Models;

namespace UIL.App_Code
{
    public static class BeachHotelHelper
    {
        public static HtmlString CoastLine(this IHtmlHelper html, HotelViewModel hotel)
        {
            BeachHotelViewModel beachHotel = hotel as BeachHotelViewModel;
            if(beachHotel == null)
            {
                return null;
            }
            string result = "<p>";

            result = $"{result}<span class=\"icon-umbrella-beach\"> {beachHotel.DistanceFromTheSea}</span>";

            result = $"{result}</p>";

            return new HtmlString(result);
        }
    }
}
