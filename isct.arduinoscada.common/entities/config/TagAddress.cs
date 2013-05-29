namespace isct.arduinoscada.common.entities.config {
  public class TagAddress {
    public TagAddress() {
      Server = new Server {Name = "sys", Id = 9999};
    }

    public Server Server { get; set; }
    public string Group { get; set; }
    public string Item { get; set; }
  }
}