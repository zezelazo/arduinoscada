using System.Collections.Generic;

namespace isct.arduinoscada.common.entities.config {
  public class TagDefinition : Entity<long> {
    public TagDefinition() {
      Properties = new List<GenericProperty<object>>();
      Address = new TagAddress();
      Transformation = new TagTransformation();
      Alarm =new TagAlarm();
    }

    public TagAddress Address { get; set; }
    public TagTransformation Transformation { get; set; }
    public TagAlarm Alarm { get; set; }
    public List<GenericProperty<object>> Properties { get; set; }
  }
}