using GraphQLSample.DataAccess;
using HotChocolate.Types;

namespace GraphQLSample.Models;
public class Book
{
    public int? Id { get; set; }
    public string? Title { get; set; }
    public int? AuthorId { get; set; }
}

public class BookType : ObjectType<Book>
{
    protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor.BindFields(BindingBehavior.Implicit);
        descriptor.Field("author")
            .Resolve(context => {
                return Database.Authors.Single(author => author.Id == context.Parent<Book>().AuthorId);
            });
    }
}