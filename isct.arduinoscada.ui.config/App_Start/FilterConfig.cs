using System.Web;
using System.Web.Mvc;

namespace isct.arduinoscada.ui.config
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}