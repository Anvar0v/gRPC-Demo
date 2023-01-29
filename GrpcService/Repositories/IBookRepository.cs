namespace GrpcServer.Repositories;
public interface IBookRepository
{
    int AddBook(BookModel book);
    BookModel GetBookById(int id);
    List<BookModel> GetBooks();
    bool UpdateBook(int id, BookModel book);
    bool DeleteBookById(int id);
}