using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NLog;
using Raven.Client;
using Raven.Client.Linq;
using isct.arduinoscada.common.entities;
using isct.arduinoscada.common.services.config;

namespace isct.arduinoscada.services.config {
  public class ConfigurationService : IConfigurationService, IDisposable {
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    private readonly IAsyncDocumentSession _dao;

    #region Constructor

    public ConfigurationService(IAsyncDocumentSession dao) {
      _dao = dao;
    }

    #endregion

    #region Implementation of IConfigurationService

    public async Task<long> CreateUser(User item) {
      var result = await StoreItem(item);
      return result;
    }

    public async void EditUser(User item) {
      await StoreItem(item);
    }

    public void DeleteUser(User item) {
      DeleteItem(item);
    }

    public async Task<long> CreateTag(TagDef item) {
      var result = await StoreItem(item);
      return result;
    }

    public async void EditTag(TagDef item) {
      await StoreItem(item);
    }

    public void DeleteTag(TagDef item) {
      DeleteItem(item);
    }

    public async Task<long> CreateDevice(ArdDevice item) {
      var result = await StoreItem(item);
      return result;
    }

    public async void EditDevice(ArdDevice item) {
      await StoreItem(item);
    }

    public void DeleteDevice(ArdDevice item) {
      DeleteItem(item);
    }

    public Task<IList<ArdDevice>> GetDevices(Expression<Func<ArdDevice, bool>> filter = null) {
      return _dao.Query<ArdDevice>().Where(GetFilterExpression(filter)).ToListAsync();
    }

    public Task<IList<User>> GetUsers(Expression<Func<User, bool>> filter = null) {
      return _dao.Query<User>().Where(GetFilterExpression(filter)).ToListAsync();
    }

    public Task<IList<TagDef>> GetTags(Expression<Func<TagDef, bool>> filter = null) {
      return _dao.Query<TagDef>().Where(GetFilterExpression(filter)).ToListAsync();
    }

    public async Task<User> GetUser(long userId) {
      var result = await _dao.LoadAsync<User>(userId);
      return result;
    }

    public async Task<TagDef> GetTag(long tagId) {
      var result = await _dao.LoadAsync<TagDef>(tagId);
      return result;
    }

    public async Task<ArdDevice> GetDevice(long deviceId) {
      var result = await _dao.LoadAsync<ArdDevice>(deviceId);
      return result;
    }

    #endregion

    private Expression<Func<T, bool>> GetFilterExpression<T>(Expression<Func<T, bool>> filter) where T : IEntity {
      return filter ?? (_ => true);
    }

    private async void DeleteItem<T>(T item) where T : IEntity {
      try {
        _dao.Delete(item);
        await _dao.SaveChangesAsync();
      } catch(Exception e) {
        Logger.ErrorException(e.Message, e);
      }
    }

    private async Task<long> StoreItem<T>(T item) where T : IEntity {
      try {
        await _dao.StoreAsync(item);
        await _dao.SaveChangesAsync();
        return item.Id;
      } catch(Exception e) {
        Logger.ErrorException(e.Message, e);
        return 0;
      }
    }

    #region Implementation of IDisposable

    public void Dispose() {
      _dao.Dispose();
    }

    #endregion
  }
}