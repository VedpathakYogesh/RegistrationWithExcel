using System.Web;
using System.Web.Mvc;

namespace Working_With_Files_ASP_NET_MVC_5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
