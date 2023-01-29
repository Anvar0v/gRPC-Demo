using GrpcServer.Repositories;
using GrpcServer.Services;
using GrpcService.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<IBookRepository, BookRepository>();
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<BookService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
