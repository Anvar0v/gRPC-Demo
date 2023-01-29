using Grpc.Core;
using Grpc.Net.Client;
using GrpcServer;

var channel = GrpcChannel.ForAddress("http://localhost:5086", new GrpcChannelOptions
{
    Credentials = ChannelCredentials.Insecure
});
//we have to get an object from our service
var client = new Book.BookClient(channel);

var addBookRequest = new AddBookRequest()
{
    Book = new BookModel()
    {
        Id = 2,
        Author = "J.K.Rowling",
        Title = "Harry Potter",
        PublishedYear = 1990,
    }
};
var reply = await client.AddBookAsync(addBookRequest);
Console.WriteLine(reply.BookId);

var getBookRequest = new GetBookByIdRequest { Id= 1 };
var getBookReply = await client.GetBookByIdAsync(getBookRequest);
Console.WriteLine($"Title: {getBookReply.Book.Title} \nAuthor {getBookReply.Book.Author}");

Console.ReadLine();

