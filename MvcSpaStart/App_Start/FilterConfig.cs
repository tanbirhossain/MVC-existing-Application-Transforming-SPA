using System.Web.Mvc;
using MvcSpaStart.Infrastructure;

namespace MvcSpaStart
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new SpaResponseAttribute());
        }
    }
}
