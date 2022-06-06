using System.Web;
using System.Web.Mvc;

namespace Duy_Khai___Lap_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
