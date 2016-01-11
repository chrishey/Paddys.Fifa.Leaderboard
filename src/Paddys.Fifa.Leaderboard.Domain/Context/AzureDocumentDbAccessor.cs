using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace Paddys.Fifa.Leaderboard.Domain.Context
{
	public static class AzureDocumentDbAccessor 
	{
		public static async Task<DocumentCollection> DocumentDbCollection(string documentType, Database database, DocumentClient client)
		{
			var collection =
				client.CreateDocumentCollectionQuery(database.CollectionsLink).FirstOrDefault(c => c.Id == documentType) ??
				await client.CreateDocumentCollectionAsync(database.CollectionsLink, new DocumentCollection {Id = documentType});

			// parse/convert the document collection to the type?
		    return collection;
		}
	}
}
