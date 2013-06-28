using System.Threading.Tasks;
using isct.arduinoscada.common.entities;

namespace isct.arduinoscada.common.services.runtime {
  public interface IDatabase : IBaseRtService {
    void Init();
    Task<RtTag> GetTag(long id);
    void UpdateTag(RtTag item);
    
    Task<TagDef> GetTagDef(long id);
  }
}