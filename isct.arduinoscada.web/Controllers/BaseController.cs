using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using Raven.Client;
using Raven.Client.Document;
using isct.arduinoscada.common.services.config;
using isct.arduinoscada.services.config;

namespace isct.arduinoscada.web.Controllers {
  public abstract class BaseController : ApiController {
    private static readonly Lazy<IDocumentStore> LazyDocStore = new Lazy<IDocumentStore>(() => {
      var docStore = new DocumentStore {Url = "http://localhost:8080", DefaultDatabase = "arduinosacada.config"};
      docStore.Initialize();
      return docStore;
    });

    private IDocumentStore Store {
      get { return LazyDocStore.Value; }
    }

    public IConfigurationService Service { get; set; }

    public override async Task<HttpResponseMessage> ExecuteAsync(HttpControllerContext controllerContext, CancellationToken cancellationToken) {
      using(Service = new ConfigurationService(Store.OpenAsyncSession())) {
        var result = await base.ExecuteAsync(controllerContext, cancellationToken);
        return result;
      }
    }
  }
}