using System.Web;
using System.Web.Mvc;
using TestLife.Filters;

namespace TestLife
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthFilterAttribute());
            filters.Add(new ErrorFilterAttribute());
        }
    }
}