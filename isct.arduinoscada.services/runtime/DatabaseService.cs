using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using isct.arduinoscada.common.entities;
using isct.arduinoscada.common.services.runtime;
using isct.arduinoscada.services.common;

namespace isct.arduinoscada.services.runtime
{
    class DatabaseService :BaseRtService, IDatabase
    {

        #region Base Class Overrrides

        public override void Start(params dynamic[] args)
        {
            base.Start(args);
        }

        public override void Stop(params dynamic[] args)
        {
            base.Stop(args);
        }

        #endregion

        #region Implementation of IDatabase

        public void Init() {
         
        }

        public async Task<RtTag> GetTag(long id) {
            throw new NotImplementedException();
        }

        public async void UpdateTag(RtTag item) {
            throw new NotImplementedException();
        }

        public async Task<TagDef> GetTagDef(long id) {
            throw new NotImplementedException();
        }

        #endregion
    }
}
