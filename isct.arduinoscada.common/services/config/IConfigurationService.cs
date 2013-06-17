using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using isct.arduinoscada.common.entities;

namespace isct.arduinoscada.common.services.config {
  public interface IConfigurationService {
    //User Management
    IEnumerable<User> GetUsers(Expression<Func<bool, User>> filter = null);
    User GetUser(int userId);
    int CreateUser(User item);
    void EditUser(User item);
    void DeleteUser(User item);

    //TagManagement
    IEnumerable<TagDef> GetTags(Expression<Func<bool, TagDef>> filter = null);
    User GetTag(int tagId);
    int CreateTag(TagDef item);
    void EditTag(TagDef item);
    void DeleteTag(TagDef item);

    //DeviceManagent
    IEnumerable<ArduinoDevice> GetDevices(Expression<Func<bool, ArduinoDevice>> filter = null);
    User GetDevice(int deviceId);
    int CreateDevice(ArduinoDevice item);
    void EditDevice(ArduinoDevice item);
    void DeleteDevice(ArduinoDevice item);
  }
}