namespace isct.arduinoscada.common.entities.config {
  public class User : Entity<long> {
    public string Login { get; set; } 
    public string Rol { get; set; }
    public string Password { get; set;   }
    public string PicturePath { get; set; }
  }
}