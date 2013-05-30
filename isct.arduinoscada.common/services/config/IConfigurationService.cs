using System.Collections.Generic;
using isct.arduinoscada.common.entities.config;

namespace isct.arduinoscada.common.services.config {
  public interface IConfigurationService {
    void CreateServer(Server item);
    void UpdateServer(Server item);
    void DeleteServer(Server item);

    Server GetServerByName(string name);
    IEnumerable<Server> GetServers();
    Server GetServerById(long id);

    void CreateTagdefinition(TagDefinition item);
    void UpdateTagdefinition(TagDefinition item);
    void DeleteTagdefinition(TagDefinition item);

    TagDefinition GetTagDefinitionByName(string name);
    IEnumerable<TagDefinition> GetTagDefinitions();
    TagDefinition GetTagDefinitionById(long id);
  }
}