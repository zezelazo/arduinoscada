using System.Collections.Generic;
using System.Web.Http;
using isct.arduinoscada.common.entities;
using isct.arduinoscada.common.services.config;

namespace isct.arduinoscada.web.Controllers {
    public class UsersController : ApiController {
        private readonly IConfigurationService _service;

        public UsersController(IConfigurationService service) {
            _service = service;
        }

        public IEnumerable<User> Get() {
            return _service.GetUsers();
        }

        public User Get(long userId) {
            return _service.GetUser(userId);
        }
    }
}