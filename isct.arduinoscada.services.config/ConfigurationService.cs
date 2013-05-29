using System.Collections.Generic;
using isct.arduinoscada.common.entities.config;
using isct.arduinoscada.common.services.config;

namespace isct.arduinoscada.services.config {
  class ConfigurationService : IConfigurationService {
    #region Implementation of IConfigurationService

    public long CreateServer(Server item) {
      throw new System.NotImplementedException();
    }

    public bool UpdateServer(Server item) {
      throw new System.NotImplementedException();
    }

    public bool DeleteServer(Server item) {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Server> GetServerByName(string name) {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Server> GetServers() {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Server> GetServerById(long id) {
      throw new System.NotImplementedException();
    }

    public long CreateTagdefinition(TagDefinition item) {
      throw new System.NotImplementedException();
    }

    public bool UpdateTagdefinition(TagDefinition item) {
      throw new System.NotImplementedException();
    }

    public bool DeleteTagdefinition(TagDefinition item) {
      throw new System.NotImplementedException();
    }

    public IEnumerable<TagDefinition> GetTagDefinitionByName(string name) {
      throw new System.NotImplementedException();
    }

    public IEnumerable<TagDefinition> GetTagDefinitions() {
      throw new System.NotImplementedException();
    }

    public IEnumerable<TagDefinition> GetTagDefinitionById(long id) {
      throw new System.NotImplementedException();
    }

    #endregion
  }
}