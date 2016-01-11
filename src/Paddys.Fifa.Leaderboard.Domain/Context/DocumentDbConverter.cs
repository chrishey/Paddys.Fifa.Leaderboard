using System.Collections.Generic;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace Paddys.Fifa.Leaderboard.Domain.Context
{
    public class DocumentDbConverter<T> where T : class
    {
        //public static IList<T> DocumentsFromCollection(DocumentCollection collection, DocumentClient client)
        //{
        //    var documents = client.CreateDocumentQuery("dbs/" + )
        //}
    }
}
