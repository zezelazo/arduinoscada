using System.Web.Http;
using Ninject;

namespace isct.arduinoscada.web.App_Start {
  public class IocConfig {
    public static void RegisterIoc(HttpConfiguration config) {
      var kernel = new StandardKernel();

    }
  }
}