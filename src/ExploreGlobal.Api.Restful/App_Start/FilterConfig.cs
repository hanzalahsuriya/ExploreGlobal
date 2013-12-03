using System.Web;
using System.Web.Mvc;

namespace ExploreGlobal.Api.Restful
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}