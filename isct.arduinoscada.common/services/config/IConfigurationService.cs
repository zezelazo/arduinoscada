using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using isct.arduinoscada.common.entities;

namespace isct.arduinoscada.common.services.config {
  public interface IConfigurationService : IDisposable {
    //User Management
    Task<IList<User>> GetUsers(Expression<Func<User, bool>> filter = null);
    Task<User> GetUser(long userId);
    Task<long> CreateUser(User item);
    void EditUser(User item);
    void DeleteUser(User item);

    //TagManagement
    Task<IList<TagDef>> GetTags(Expression<Func<TagDef, bool>> filter = null);
    Task<TagDef> GetTag(long tagId);
    Task<long> CreateTag(TagDef item);
    void EditTag(TagDef item);
    void DeleteTag(TagDef item);

    //DeviceManagent
    Task<IList<ArdDevice>> GetDevices(Expression<Func<ArdDevice, bool>> filter = null);
    Task<ArdDevice> GetDevice(long deviceId);
    Task<long> CreateDevice(ArdDevice item);
    void EditDevice(ArdDevice item);
    void DeleteDevice(ArdDevice item);
  }
}