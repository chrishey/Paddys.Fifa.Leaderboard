using Microsoft.ApplicationServer.Caching;

namespace Paddys.Fifa.Leaderboard.Data.Cache.Azure
{
    public class AzureDataCache
    {
        public DataCache GetDataCache()
        {
            var cacheFactory = new DataCacheFactory();
            return cacheFactory.GetDefaultCache();
        }
    }
}
