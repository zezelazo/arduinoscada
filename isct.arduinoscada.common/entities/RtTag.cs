using System;

namespace isct.arduinoscada.common.entities {
  public class RtTag : IEntity {
    public RtTag() {
      TimeStamp = DateTime.Now;
      Value = null;
    }

    public object Value { get; set; }
    public object TimeStamp { get; set; }
    public long Id { get; set; }
  }
}