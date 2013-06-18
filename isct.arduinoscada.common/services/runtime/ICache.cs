using System;
using System.Collections.Generic;
using isct.arduinoscada.common.entities;

namespace isct.arduinoscada.common.services.runtime {
  public interface ICache : IBaseService {
    int AddItem(long id, RtTag tag);

    void ClearItem(long id);

    RtTag GetLastestItem(long id);

    RtTag GetOldestItem(long id);

    IEnumerable<RtTag> GetAllItems(long id, int order); //1=ascend; 2= desc

    event EventHandler<EventArgs> NewValues;
  }
}