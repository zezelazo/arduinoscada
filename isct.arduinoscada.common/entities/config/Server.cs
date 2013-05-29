using System.Collections.Generic;

namespace isct.arduinoscada.common.entities.config {
  public class Server : Entity<long> {
    public Server() {
      Properties = new List<GenericProperty<object>>();
    }   
    public IEnumerable<GenericProperty<object>> Properties { get; set; }
  }
}