namespace GrpcServer.Repositories;
public class BookRepository : IBookRepository
{
    private readonly List<BookModel> _books;

    public BookRepository()
    {
        _books = new List<BookModel>();
        
        _books.Add(new BookModel()
        {
            Id = 1,
            Author = "Akrom Malik",
            Title = "Halqa",
            PublishedYear = 2021,
        });
    }

    public int AddBook(BookModel book)
    {
        _books.Add(book);
        return book.Id;
    }

    public bool DeleteBookById(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);

        if (book != null)
        {
            _books.Remove(book);
            return true;
        }

        return false;
    }

    public List<BookModel> GetBooks()
    {
        return this._books;
    }

    public BookModel GetBookById(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);

        if (book == null)
            throw new Exception("Entity was not found");

        return book;
    }

    public bool UpdateBook(int id, BookModel book)
    {
        var existingBook = _books.FirstOrDefault(b => b.Id == id);
        if (existingBook != null)
        {
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.PublishedYear = book.PublishedYear;
            return true;
        }

        return false;
    }
}
