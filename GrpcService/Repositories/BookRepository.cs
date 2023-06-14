using GrpcServer.Data;

namespace GrpcServer.Repositories;
public class BookRepository : IBookRepository
{
    private readonly AppDbContext _context;
    public BookRepository(AppDbContext context)
        => _context = context;

    public int AddBook(BookModel book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
        return book.Id;
    }

    public List<BookModel> GetBooks()
        => _context.Books.ToList();

    public BookModel GetBookById(int id)
    {
        var book = _context.Books.FirstOrDefault(b => b.Id == id);

        if (book is null)
            return null;

        return book;
    }
    public bool UpdateBook(int id, BookModel book)
    {
        var existingBook = GetBookById(id);
        if (existingBook != null)
        {
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.PublishedYear = book.PublishedYear;
            return true;
        }
        return false;
    }

    public bool DeleteBookById(int id)
    {
        var book = GetBookById(id);

        if (book != null)
        {
            _context.Books.Remove(book);
            return true;
        }
        return false;
    }
}
