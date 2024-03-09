using GraphQLSample.Models;
using GraphQLSample.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<BookType>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
