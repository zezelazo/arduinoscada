using System.Collections.Generic;
using System.Web.Http;
using isct.arduinoscada.common.entities;
using isct.arduinoscada.common.services.config;

namespace isct.arduinoscada.web.Controllers {
    public class TagsController : ApiController {
        private readonly IConfigurationService _service;

        public TagsController(IConfigurationService service) {
            _service = service;
        }

        public IEnumerable<TagDef> Get() {
            return _service.GetTags();
        }

        public TagDef Get(long tagId) {
            return _service.GetTag(tagId);
        }
    }
}