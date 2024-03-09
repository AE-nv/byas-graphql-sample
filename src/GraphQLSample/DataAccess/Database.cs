using GraphQLSample.Models;

namespace GraphQLSample.DataAccess
{
    public static class Database
    {
        public static Book[] Books { get {
            return new [] {
                new Book(){
                    Id = 1,
                    Title = "Book 1",
                    AuthorId = Authors.ElementAt(0).Id
                },
                new Book(){
                    Id = 2,
                    Title = "Book 2",
                    AuthorId = Authors.ElementAt(1).Id
                }
            };
        }}

        public static Author[] Authors { get {
            return new [] {
                new Author(){
                    Id = 1,
                    Name = "Leendert"
                },
                new Author(){
                    Id = 2,
                    Name = "Marlies"
                }
            };
        }}
    }
}