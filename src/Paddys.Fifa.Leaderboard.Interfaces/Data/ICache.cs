namespace Paddys.Fifa.Leaderboard.Interfaces.Data
{
    public interface ICache<T> where T : class
    {
        T Get(string key);
        void Put(string key, T value);
    }
}
