using System.Web;
using System.Web.Mvc;

namespace DcdK22CNT4Lesson10Db
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
