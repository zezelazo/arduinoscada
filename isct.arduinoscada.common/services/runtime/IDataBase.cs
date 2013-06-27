using isct.arduinoscada.common.entities;

namespace isct.arduinoscada.common.services.runtime {
  public interface IDataBase : IBaseRtService {
    void Init();
    RtTag GetTag(long id);
    void UpdateTag(RtTag item);
    
    TagDef GetTagDef(long id);
  }
}