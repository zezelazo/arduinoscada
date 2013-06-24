using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using isct.arduinoscada.common.entities;

namespace isct.arduinoscada.web.Controllers {
  public class UsersController : BaseController {
    public Task<IList<User>> Get() {
      return Service.GetUsers();
    }

    public Task<User> Get(long userId) {
      return Service.GetUser(userId);
    }

    public void Put(User item) {
      Service.EditUser(item);
    }

    public async Task<HttpResponseMessage> Post(User item) {
      var id = await Service.CreateUser(item);
      return Request.CreateResponse(HttpStatusCode.Accepted, id);
    }
  }
}