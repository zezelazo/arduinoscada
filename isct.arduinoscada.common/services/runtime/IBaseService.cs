namespace isct.arduinoscada.common.services.runtime {
  public interface IBaseService {
    void Start(params dynamic[] args);
    void Stop(params dynamic[] args);
    void LogEvent();
  }
}