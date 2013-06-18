using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NLog;
using Raven.Client;
using Raven.Client.Linq;
using isct.arduinoscada.common.entities;
using isct.arduinoscada.common.services.config;

namespace isct.arduinoscada.services.config {
  public class ConfigurationService : IConfigurationService {
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    private readonly IDocumentSession _dao;

    #region Constructor

    public ConfigurationService(IDocumentSession dao) {
      _dao = dao;
    }

    #endregion

    #region Implementation of IConfigurationService

    public long CreateUser(User item) {
      return StoreItem(item);
    }

    public void EditUser(User item) {
      StoreItem(item);
    }

    public void DeleteUser(User item) {
      DeleteItem(item);
    }

    public long CreateTag(TagDef item) {
      return StoreItem(item);
    }

    public void EditTag(TagDef item) {
      StoreItem(item);
    }

    public void DeleteTag(TagDef item) {
      DeleteItem(item);
    }

    public long CreateDevice(ArdDevice item) {
      return StoreItem(item);
    }

    public void EditDevice(ArdDevice item) {
      StoreItem(item);
    }

    public void DeleteDevice(ArdDevice item) {
      DeleteItem(item);
    }

    public IEnumerable<ArdDevice> GetDevices(Expression<Func<ArdDevice, bool>> filter = null) {
      return _dao.Query<ArdDevice>().Where(GetFilterExpression(filter));
    }

    public IEnumerable<User> GetUsers(Expression<Func<User, bool>> filter = null) {
      return _dao.Query<User>().Where(GetFilterExpression(filter));
    }

    public IEnumerable<TagDef> GetTags(Expression<Func<TagDef, bool>> filter = null) {
      return _dao.Query<TagDef>().Where(GetFilterExpression(filter));
    }

    public User GetUser(long userId) {
      return _dao.Load<User>(userId);
    }

    public TagDef GetTag(long tagId) {
      return _dao.Load<TagDef>(tagId);
    }

    public ArdDevice GetDevice(long deviceId) {
      return _dao.Load<ArdDevice>(deviceId);
    }

    #endregion

    private Expression<Func<T, bool>> GetFilterExpression<T>(Expression<Func<T, bool>> filter) where T : IEntity {
      return filter ?? (_ => true);
    }

    private void DeleteItem<T>(T item) where T : IEntity {
      try {
        _dao.Delete(item);
        _dao.SaveChanges();
      } catch(Exception e) {
        Logger.ErrorException(e.Message, e);
      }
    }

    private long StoreItem<T>(T item) where T : IEntity {
      try {
        _dao.Store(item);
        _dao.SaveChanges();
        return item.Id;
      } catch(Exception e) {
        Logger.ErrorException(e.Message, e);
        return 0;
      }
    }
  }
}