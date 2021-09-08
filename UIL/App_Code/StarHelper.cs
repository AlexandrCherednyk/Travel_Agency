using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using UIL.Models;

namespace UIL.App_Code
{
    public static class StarHelper
    {
        public static HtmlString StarRating(this IHtmlHelper html, StarRating starRating)
        {
            int starCount = (int)starRating;
            string result = "<p class=\"starRating\">";

            for(int counter=0; counter<starCount; counter++)
            {
                result = $"{result}<span class=\"icon-star\"></span>";
            }
        
            for(int counter=0; counter < 5 - starCount; counter++)
            {
                result = $"{result}<span class=\"icon-empty-star\"></span>";
            }

            result = $"{result}</p>";

            return new HtmlString(result);
        }
    }
}
