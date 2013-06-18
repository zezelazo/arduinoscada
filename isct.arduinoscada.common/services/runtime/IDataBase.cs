using isct.arduinoscada.common.entities;

namespace isct.arduinoscada.common.services.runtime {
  public interface IDataBase : IBaseService {
    void Init();
    RtTag GetRtTag(long id);
    TagDef GetTagDef(long Id);
  }
}