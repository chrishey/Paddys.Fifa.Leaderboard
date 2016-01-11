using System.Collections.Generic;
using Microsoft.Azure.Documents;

namespace Paddys.Fifa.Leaderboard.Domain.Context
{
    public class DocumentDbConverter<T> where T : class
    {
        public static IList<T> DocumentsFromCollection(DocumentCollection collection)
        {
            return new List<T>();
        }
    }
}
