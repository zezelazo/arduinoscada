using System.Collections.Generic;
using System.Web.Http;
using isct.arduinoscada.common.entities;
using isct.arduinoscada.common.services.config;

namespace isct.arduinoscada.web.Controllers {
    public class DevicesController : ApiController {
        private readonly IConfigurationService _service;

        public DevicesController(IConfigurationService service) {
            _service = service;
        }

        public IEnumerable<ArdDevice> Get() {
            return _service.GetDevices();
        }

        public ArdDevice Get(long deviceId) {
            return _service.GetDevice(deviceId);
        }
    }
}