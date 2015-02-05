namespace Paddys.Fifa.Leaderboard.Interfaces.Data
{
    public interface ICache
    {
        object Get(string key);
        void Put(string key, object value);
    }
}
