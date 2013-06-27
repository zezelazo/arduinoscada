using System;

namespace isct.arduinoscada.common.services.runtime {
  public interface IBaseRtService : IDisposable {
    void Start(params dynamic[] args);
    void Stop(params dynamic[] args);
    void LogEvent();
  }
}