namespace Paddys.Fifa.Leaderboard.Data.Cache
{
    public interface ICache
    {
        object Get(string key);
        void Put(string key, object value);
    }
}
