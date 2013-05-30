using System;
using System.Collections.Generic;
using System.Linq;
using Raven.Client;
using Raven.Client.Linq;
using isct.arduinoscada.common.entities.config;
using isct.arduinoscada.common.services.config;

namespace isct.arduinoscada.services.config {
  internal class ConfigurationService : IConfigurationService {
    private IDocumentSession _dao;

    #region Constructor

    public ConfigurationService(IDocumentSession dao) {
      _dao = dao;
    }

    #endregion

    #region Implementation of IConfigurationService

    public long CreateServer(Server item) {
      throw new NotImplementedException();
    }

    public bool UpdateServer(Server item) {
      throw new NotImplementedException();
    }

    public bool DeleteServer(Server item) {
      throw new NotImplementedException();
    }

    public Server GetServerByName(string name) {
      var server = _dao.Query<Server>().FirstOrDefault(s => string.Compare(s.Name, name, StringComparison.OrdinalIgnoreCase)=0);
      

    }

    public IEnumerable<Server> GetServers() {
      var servers=_dao.Query<Server>().OrderBy(s => s.Name).ToList();
      return servers;
    }

    public Server GetServerById(long id) {
      var server = _dao.Load<Server>(id);
      return server;
    }

    public long CreateTagdefinition(TagDefinition item) {
      throw new NotImplementedException();
    }

    public bool UpdateTagdefinition(TagDefinition item) {
      throw new NotImplementedException();
    }

    public bool DeleteTagdefinition(TagDefinition item) {
      throw new NotImplementedException();
    }

    public IEnumerable<TagDefinition> GetTagDefinitionByName(string name) {
      throw new NotImplementedException();
    }

    public IEnumerable<TagDefinition> GetTagDefinitions() {
      throw new NotImplementedException();
    }

    public IEnumerable<TagDefinition> GetTagDefinitionById(long id) {
      throw new NotImplementedException();
    }

    #endregion
  }
}