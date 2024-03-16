
namespace WebApplication1.Data.Repository;

public class BookRepository : IBookRespository
{
    private readonly AppDbContext _context;
    public BookRepository(AppDbContext dbContext)
    {
        _context = dbContext;
    }
    public void Create(Book book)
    {
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void Delete(Book book)
    {
        _context.Books.Remove(book);
        _context.SaveChanges();
    }

    public List<Book> GetAll()
    {
        var book = _context.Books.ToList();
        return book;
    }

    public Book GetById(int id)
    {
        var book = _context.Books.FirstOrDefault(i => i.Id == id);
        return book!;
    }

    public void Update(Book book)
    {
        _context.Books.Update(book);
        _context.SaveChanges();
    }
}
