using System.Web;
using System.Web.Mvc;

namespace MyFirstQuestion0513
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
