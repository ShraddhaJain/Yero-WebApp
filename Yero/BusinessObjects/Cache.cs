using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using Microsoft.Practices.EnterpriseLibrary.Caching.Expirations;
using Microsoft.Practices.EnterpriseLibrary.Common;

namespace Yero.BusinessObjects
{
    public class Cache
    {
        ICacheManager cacheManager;
        public Cache(string cacheName)
        {
            cacheManager = CacheFactory.GetCacheManager();
        }


        public bool setCache(object objVal, string objKey)
        {
            try
            {
                Audit.CustomLog("Start :Cache - setCache", objVal);
                if (!cacheManager.Contains("objKey"))
                {
                    cacheManager.Add(objKey, objVal, CacheItemPriority.Low, null, new SlidingTime(new TimeSpan(0, 0, 10)));
                }
                else
                {
                    cacheManager.Remove(objKey);
                    cacheManager.Add(objKey, objVal, CacheItemPriority.Low, null, new SlidingTime(new TimeSpan(0, 0, 10)));

                }
                Audit.CustomLog("End :Cache - setCache", objVal);
                return true;
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ItivoError: Cache - setCache", objVal,false);
                throw;
            }
        }

        public object getCache(string objKey)
        {
            try
            {
                Audit.CustomLog("Start :Cache - getCache", objKey);
                if (cacheManager.Contains(objKey))
                {
                    object obj = cacheManager.GetData(objKey);
                    return obj;

                }
                else
                {
                    Audit.CustomLog("ERROR: Cache: GetCache - NO CACHE FOUND", objKey);
                    return null;
                }

                Audit.CustomLog("End :Cache - getCache", objKey);
            }
            catch (Exception ex)
            {
                Audit.CustomError(ex, "ERROR: Cache: GetCache", objKey, false);
                throw;
            }
        }

        public void CacheFlush()
        {
            //only this obj how to flush? 
            cacheManager.Flush();
        }

        public void RemoveCache(string objKey)
        {
            //only this obj how to flush? 
            cacheManager.Remove("objKey");
        } 
 
    }
}
