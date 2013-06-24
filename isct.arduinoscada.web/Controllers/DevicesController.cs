using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using isct.arduinoscada.common.entities;

namespace isct.arduinoscada.web.Controllers {
  public class DevicesController : BaseController {
    public Task<IList<ArdDevice>> Get() {
      return Service.GetDevices();
    }

    public Task<ArdDevice> Get(long deviceId) {
      return Service.GetDevice(deviceId);
    }

    [ActionName("tags")]
    public Task<IList<TagDef>> GetTags(long deviceId) {
      return Service.GetTags(t => t.DeviceId == deviceId);
    }

    public void Put(ArdDevice item) {
      Service.EditDevice(item);
    }

    public async Task<HttpResponseMessage> Post(ArdDevice item) {
      var id = await Service.CreateDevice(item);
      return Request.CreateResponse(HttpStatusCode.Accepted, id);
    }
  }
}