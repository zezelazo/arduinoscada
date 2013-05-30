using System.Collections.Generic;
using isct.arduinoscada.common.entities.config;

namespace isct.arduinoscada.common.services.config {
  public interface IConfigurationService {
    long CreateServer(Server item);
    bool UpdateServer(Server item);
    bool DeleteServer(Server item);

    Server GetServerByName(string name);
    IEnumerable<Server> GetServers();
    Server GetServerById(long id);

    long CreateTagdefinition(TagDefinition item);
    bool UpdateTagdefinition(TagDefinition item);
    bool DeleteTagdefinition(TagDefinition item);

    TagDefinition GetTagDefinitionByName(string name);
    IEnumerable<TagDefinition> GetTagDefinitions();
    TagDefinition GetTagDefinitionById(long id);
  }
}