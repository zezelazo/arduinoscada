using System.Collections.Generic;
using isct.arduinoscada.common.entities.config;

namespace isct.arduinoscada.common.services.config {
  public interface IUserService {
    long CreateUser(User item);
    bool UpdateUser(User item);
    bool DeleteUser(User item);

    IEnumerable<User> GetUserByName(string name);
    IEnumerable<User> GetUsers();
    IEnumerable<User> GetUserById(long id);
  }
}