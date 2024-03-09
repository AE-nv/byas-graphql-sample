using GraphQLSample.DataAccess;
using GraphQLSample.Models;

namespace GraphQLSample.Queries
{
    public class Query
    {
        public Book[] GetBooks(int? id) => Database.Books.Where(b => !id.HasValue || b.Id == id).ToArray();
    }
}