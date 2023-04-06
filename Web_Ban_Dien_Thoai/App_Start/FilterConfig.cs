using System.Web;
using System.Web.Mvc;

namespace Web_Ban_Dien_Thoai
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
