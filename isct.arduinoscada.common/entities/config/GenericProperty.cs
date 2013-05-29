namespace isct.arduinoscada.common.entities.config {
  public class GenericProperty<T> {
    public string Name { get; set; }
    public T Value { get; set; }
  }
}