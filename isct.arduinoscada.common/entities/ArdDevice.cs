using System;
using System.Collections.Generic;

namespace isct.arduinoscada.common.entities {
  public class ArdDevice : IEntity {
    public string Name { get; set; }
    public string Description { get; set; }
    public string BaseUrl { get; set; }
    public DateTime? LastTimeOnline { get; set; }

    public ICollection<TagDef> Tags { get; set; }
    public long Id { get; set; }
  }
}