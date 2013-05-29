using System.Collections.Generic;
using isct.arduinoscada.common.entities.config;

namespace isct.arduinoscada.common.services.config {
  public interface IConfigurationService {
    long CreateServer(Server item);
    bool UpdateServer(Server item);
    bool DeleteServer(Server item);

    IEnumerable<Server> GetServerByName(string name);
    IEnumerable<Server> GetServers();
    IEnumerable<Server> GetServerById(long id);

    long CreateTagdefinition(TagDefinition item);
    bool UpdateTagdefinition(TagDefinition item);
    bool DeleteTagdefinition(TagDefinition item);

    IEnumerable<TagDefinition> GetTagDefinitionByName(string name);
    IEnumerable<TagDefinition> GetTagDefinitions();
    IEnumerable<TagDefinition> GetTagDefinitionById(long id);
  }
}