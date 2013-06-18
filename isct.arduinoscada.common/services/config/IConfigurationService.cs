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
    IEnumerable<ArduinoDevice> GetDevices(Expression<Func<ArduinoDevice, bool>> filter = null);
    ArduinoDevice GetDevice(long deviceId);
    long CreateDevice(ArduinoDevice item);
    void EditDevice(ArduinoDevice item);
    void DeleteDevice(ArduinoDevice item);
  }
}