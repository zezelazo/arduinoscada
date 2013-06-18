using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NLog;
using Raven.Client;
using Raven.Client.Linq;
using isct.arduinoscada.common.entities;
using isct.arduinoscada.common.services.config;

namespace isct.arduinoscada.services.config {
    public class ConfigurationService:IConfigurationService {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IDocumentSession _dao;

        #region Constructor
        public ConfigurationService(IDocumentSession dao)
        {
            _dao = dao;
        }
        #endregion


        #region Implementation of IConfigurationService

        public IEnumerable<User> GetUsers(Expression<Func<User,bool>> filter = null) {
            if (filter == null) filter = _ => true;
            return _dao.Query<User>().Where(filter);
        }

        public User GetUser(int userId) {
            throw new NotImplementedException();
        }

        public int CreateUser(User item) {
            throw new NotImplementedException();
        }

        public void EditUser(User item) {
            throw new NotImplementedException();
        }

        public void DeleteUser(User item) {
            throw new NotImplementedException();
        }

        public IEnumerable<TagDef> GetTags(Expression<Func<bool, TagDef>> filter = null) {
            throw new NotImplementedException();
        }

        public User GetTag(int tagId) {
            throw new NotImplementedException();
        }

        public int CreateTag(TagDef item) {
            throw new NotImplementedException();
        }

        public void EditTag(TagDef item) {
            throw new NotImplementedException();
        }

        public void DeleteTag(TagDef item) {
            throw new NotImplementedException();
        }

        public IEnumerable<ArduinoDevice> GetDevices(Expression<Func<bool, ArduinoDevice>> filter = null) {
            throw new NotImplementedException();
        }

        public User GetDevice(int deviceId) {
            throw new NotImplementedException();
        }

        public int CreateDevice(ArduinoDevice item) {
            throw new NotImplementedException();
        }

        public void EditDevice(ArduinoDevice item) {
            throw new NotImplementedException();
        }

        public void DeleteDevice(ArduinoDevice item) {
            throw new NotImplementedException();
        }

        #endregion
    }
}