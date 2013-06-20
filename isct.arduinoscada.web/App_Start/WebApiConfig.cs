using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace isct.arduinoscada.web.App_Start {
  public static class WebApiConfig {
    public static string ControllerOnly = "ApiControllerOnly";
    public static string ControllerAndId = "ApiControllerAndIntegerId";
    public static string ControllerAction = "ApiControllerAction";

    public static void Register(HttpConfiguration config) {
      Configure(config);

      var routes = config.Routes;
                                                     
      routes.MapHttpRoute(name: ControllerOnly, 
                          routeTemplate: "api/{controller}");

      routes.MapHttpRoute(name: ControllerAndId, 
                          routeTemplate: "api/{controller}/{id}", 
                          defaults: null, //defaults: new { id = RouteParameter.Optional } //,
                          constraints: new { id = @"^\d+$" }); // id must be all digits

      routes.MapHttpRoute(name: ControllerAction,
                          routeTemplate: "api/{controller}/{action}");
    }

    private static void Configure(HttpConfiguration config) {
      config.Formatters.Remove(config.Formatters.XmlFormatter);
      var json = config.Formatters.JsonFormatter;
      json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    }
  }
}