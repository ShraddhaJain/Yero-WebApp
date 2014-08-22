using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Yero.DataLayer;
using Yero.BusinessObjects;


namespace Yero.BusinessObjects
{
    public class CacheUtility
    {

        Cache objCache = new Cache("mycache");
        ManageLookupDL objManageLookup = new DataLayer.ManageLookupDL();
        private static object _cacheLock = new object();

        public DataTable getDataTable(string cacheKey, string lookupKey)
        {
            Audit.CustomLog(" Start: CacheUtility - getDataTable", null);
            try
            {
                DataTable dt = (DataTable)objCache.getCache(cacheKey);
                if (dt == null)
                {
                    // lock this section of the code while we populate this.
                    lock (_cacheLock)
                    {
                        // only populate if this was not populated by another thread while this thread was waiting
                        dt = (DataTable)objCache.getCache(cacheKey);
                        if (dt == null)
                        {
                            dt = objManageLookup.GetLookupDetailValues(lookupKey);
                            bool boolAddress = objCache.setCache(dt, cacheKey);
                            if (boolAddress == false)
                                Audit.CustomLog(" WARNING: CacheUtility - GetDataTable - Cache is not setting", dt);
                        }
                    }
                }
                Audit.CustomLog(" End: CacheUtility - getDataTable", null);
                return dt;
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ERROR: CacheUtility - getDataTable", null, false);
                throw ex;
            }


        }

    }


}
