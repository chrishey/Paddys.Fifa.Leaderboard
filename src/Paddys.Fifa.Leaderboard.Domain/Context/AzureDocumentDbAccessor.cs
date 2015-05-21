using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace Paddys.Fifa.Leaderboard.Domain.Context
{
	public static class AzureDocumentDbAccessor<T> where T : class 
	{
		public static async Task<IList<T>> DocumentDbCollection(string documentType, Database database, DocumentClient client)
		{
			var documents = new List<T>();

			var collection =
				client.CreateDocumentCollectionQuery(database.CollectionsLink).FirstOrDefault(c => c.Id == documentType) ??
				await client.CreateDocumentCollectionAsync(database.CollectionsLink, new DocumentCollection {Id = documentType});

			// parse/convert the document collection to the type?

			return documents;
		}
	}
}
