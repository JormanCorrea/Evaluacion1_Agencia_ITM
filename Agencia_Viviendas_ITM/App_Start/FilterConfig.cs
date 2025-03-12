using System.Web;
using System.Web.Mvc;

namespace Agencia_Viviendas_ITM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
