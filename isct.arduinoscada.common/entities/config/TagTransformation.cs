namespace isct.arduinoscada.common.entities.config {
  public class TagTransformation {
    public TagTransformation() {
      Operation = ScalationOperation.Multiply;
      Factor = 1;
    }

    public ScalationOperation Operation { get; set; }
    public object Factor { get; set; }
  }
}