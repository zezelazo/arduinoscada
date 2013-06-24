using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using isct.arduinoscada.common.entities;

namespace isct.arduinoscada.web.Controllers {
  public class TagsController : BaseController {
    public Task<IList<TagDef>> Get() {
      return Service.GetTags();
    }

    public Task<TagDef> Get(long tagId) {
      return Service.GetTag(tagId);
    }

    public void Put(TagDef item) {
      Service.EditTag(item);
    }

    public async Task<HttpResponseMessage> Post(TagDef item) {
      var id = await Service.CreateTag(item);
      return Request.CreateResponse(HttpStatusCode.Accepted, id);
    }
  }
}