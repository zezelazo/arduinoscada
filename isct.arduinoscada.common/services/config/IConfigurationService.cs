using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using isct.arduinoscada.common.entities;

namespace isct.arduinoscada.common.services.config {
  public interface IConfigurationService {
    //User Management
    IEnumerable<User> GetUsers(Expression<Func<User, bool>> filter = null);
    User GetUser(long userId);
    long CreateUser(User item);
    void EditUser(User item);
    void DeleteUser(User item);

    //TagManagement
    IEnumerable<TagDef> GetTags(Expression<Func<TagDef, bool>> filter = null);
    TagDef GetTag(long tagId);
    long CreateTag(TagDef item);
    void EditTag(TagDef item);
    void DeleteTag(TagDef item);

    //DeviceManagent
    IEnumerable<ArdDevice> GetDevices(Expression<Func<ArdDevice, bool>> filter = null);
    ArdDevice GetDevice(long deviceId);
    long CreateDevice(ArdDevice item);
    void EditDevice(ArdDevice item);
    void DeleteDevice(ArdDevice item);
  }
}