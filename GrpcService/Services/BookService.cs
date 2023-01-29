using Grpc.Core;
using GrpcServer.Repositories;

namespace GrpcServer.Services;
public class BookService : Book.BookBase
{
    private readonly IBookRepository _repository;

    public BookService(IBookRepository repository)
    {
        _repository = repository;
    }

    public override Task<GetBooksResponse> GetBooks(GetBooksRequest request, ServerCallContext context)
    {
        var books = _repository.GetBooks();

        return Task.FromResult(new GetBooksResponse { Book = { books } });
    }

    public override Task<GetBookResponse> GetBookById(GetBookByIdRequest request, ServerCallContext context)
    {
        //! modelimizdan yengi obyekt olib to'ldirib ketvuramiz ichini
        var book = _repository.GetBookById(request.Id);

        return Task.FromResult(new GetBookResponse { Book = book });
    }

    public override Task<AddBookResponse> AddBook(AddBookRequest request, ServerCallContext context)
    {
        var id = _repository.AddBook(request.Book);

        return Task.FromResult(new AddBookResponse() { BookId = id });
    }
    public override Task<UpdateBookResponse> UpdateBook(UpdateBookRequest request, ServerCallContext context)
    {
        var isSuccess = _repository.UpdateBook(request.Book.Id, request.Book);

        return Task.FromResult(new UpdateBookResponse { IsSuccess = isSuccess });
    }

    public override Task<DeleteBookResponse> DeleteBook(DeleteBookRequest request, ServerCallContext context)
    {
        var isSuccess = _repository.DeleteBookById(request.Id);

        return Task.FromResult(new DeleteBookResponse { IsSuccess = isSuccess });
    }
}
