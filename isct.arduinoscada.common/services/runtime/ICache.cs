using System;
using System.Collections.Generic;
using isct.arduinoscada.common.entities.runtime;

namespace isct.arduinoscada.common.services.runtime {
  public interface ICache:IBaseService {
    int AddItem(long id, TagRecord<object> tag);

    void ClearItem(long id);

    TagRecord<object> GetLastestItem(long id);

    TagRecord<object> GetOldestItem(long id);

    IEnumerable<TagRecord<object>> GetAllItems(long id, int order);//1=ascend; 2= desc

    event EventHandler<EventArgs> NewValues;
  }
}