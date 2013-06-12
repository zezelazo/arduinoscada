using System;
using System.Collections.Generic;
using System.Linq;
using Raven.Client;
using Raven.Client.Linq;
using isct.arduinoscada.common.entities.config;
using isct.arduinoscada.common.services.config;

namespace isct.arduinoscada.services.config {
  internal class ConfigurationService : IConfigurationService {
    private readonly IDocumentSession _dao;

    #region Constructor     
    public ConfigurationService(IDocumentSession dao) {
      _dao = dao;
    }     
    #endregion

    #region Implementation of IConfigurationService

    public void CreateServer(Server item) {
       _dao.Store(item);
       _dao.SaveChanges();
    }

    public void UpdateServer(Server item) {
      var element = _dao.Load<Server>(item.Id);
      element = item;
      _dao.SaveChanges();
    }

    public void DeleteServer(Server item) {
     _dao.Delete(item);
     _dao.SaveChanges();
    }

    public Server GetServerByName(string name) {
      var server = _dao.Query<Server>().FirstOrDefault(s => string.Compare(s.Name, name, StringComparison.OrdinalIgnoreCase)==0);
      return server;

    }

    public IEnumerable<Server> GetServers() {
      var servers=_dao.Query<Server>().OrderBy(s => s.Name).ToList();
      return servers;
    }

    public Server GetServerById(long id) {
      var server = _dao.Load<Server>(id);
      return server;
    }

    public void  CreateTagdefinition(TagDefinition item) {
      _dao.Store(item);
      _dao.SaveChanges();
    }

    public void UpdateTagdefinition(TagDefinition item) {
      var element = _dao.Load<TagDefinition>(item.Id);
      element = item;
      _dao.SaveChanges();      
    }

    public void DeleteTagdefinition(TagDefinition item) {
      _dao.Store(item);
      _dao.SaveChanges();
    }

    public TagDefinition GetTagDefinitionByName(string name) {
      var tagdef = _dao.Query<TagDefinition>().FirstOrDefault(t => string.Compare(t.Name, name, StringComparison.OrdinalIgnoreCase) == 0);
      return tagdef;
    }

    public IEnumerable<TagDefinition> GetTagDefinitions() {
      var tagdefs = _dao.Query<TagDefinition>();
      return tagdefs;
    }

    public TagDefinition GetTagDefinitionById(long id) {
      var tagdef = _dao.Load<TagDefinition>(id);
      return tagdef;
    }

    #endregion
  }
}