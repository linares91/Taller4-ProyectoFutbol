using System.Web;
using System.Web.Mvc;

namespace Taller4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //TEST
            filters.Add(new HandleErrorAttribute());
        }
    }
}
