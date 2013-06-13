namespace isct.arduinoscada.common.services.common {
  public interface ILog {
    void Error(string message);
    void Warning(string message);
    void Info(string message);
  }
}