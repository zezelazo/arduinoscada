namespace isct.arduinoscada.common.entities {
  public class User : IEntity {
    public User() {
      Rol = EUserRol.User;
    }

    public string UserName { get; set; }
    public string RealName { get; set; }
    public string Email { get; set; }
    public EUserRol Rol { get; set; }
    public long Id { get; set; }
  }
}