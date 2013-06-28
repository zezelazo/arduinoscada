using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isct.arduinoscada.common.services.runtime;

namespace isct.arduinoscada.services.common
{
    public abstract class BaseRtService  :IBaseRtService
    {
        #region Implementation of IDisposable

        public void Dispose() {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of IBaseRtService
    
        public virtual void Start(params dynamic[] args) {
             
        }

        public virtual void Stop(params dynamic[] args) {
             
        }

        public void LogEvent() {
             
        }

        #endregion
    }
}
