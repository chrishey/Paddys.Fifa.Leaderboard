namespace Paddys.Fifa.Leaderboard.Data.Cache.Azure
{
    public class AzureCache : ICache
    {
        private readonly IDataCache _dataCache;

        public AzureCache(IDataCache dataCache)
        {
            _dataCache = dataCache;
        }

        public object Get(string key)
        {
            var dataCache = _dataCache.GetDataCache();
            return dataCache.Get(key);
        }

        public void Put(string key, object value)
        {
            var dataCache = _dataCache.GetDataCache();
            dataCache.Add(key, value);
        }
    }
}
