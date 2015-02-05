using System;
using System.Web;

namespace Paddys.Fifa.Leaderboard.Data.Cache
{
    public class WebCache : ICache
    {
        public object Get(string key)
        {
            // maybe do something with default representations being returned?
            // TODO: Check for null refs

            return HttpContext.Current.Cache[key];
        }

        public void Put(string key, object value)
        {
            // Possibly pass in more parameters for expiration, dependency, priority, etc
            HttpContext.Current.Cache.Insert(key, value);
        }
    }
}
