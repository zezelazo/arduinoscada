using System;

namespace isct.arduinoscada.common.entities {
  public class RtTag {
    public RtTag() {
      TimeStamp = DateTime.Now;
      Value = null;
    }

    public long Id { get; set; }
    public object Value { get; set; }
    public object TimeStamp { get; set; }
  }
}