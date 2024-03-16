using WebApplication1.BL.DTOs;
using WebApplication1.Data.Repository;

namespace WebApplication1.BL.Services;

public class BookService(IBookRespository bookRespository) : IBookService
{
    private readonly IBookRespository bookre = bookRespository;

    public void Create(AddBookDto dto)
    {
        Book book = new Book()
        {
            Title = dto.Title,
            Description = dto.Description,
            Author = dto.Author,
            PageCount = dto.PageCount,
        };
        bookre.Create(book);
    }

    public void Delete(int id)
    {
        var books = bookre.GetById(id);
        bookre.Delete(books);
    }

    public List<BookDto> GetAll()
    {
       var books = bookre.GetAll();
        return books.Select(book => new BookDto()
        {
            Id = book.Id,
            Title = book.Title,
            Description = book.Description,
            Author = book.Author,
            PageCount = book.PageCount,
        }).ToList();
    }

    public BookDto GetById(int id)
    {
        var books = bookre.GetById(id);
        var dto = new BookDto()
        {
            Id = books.Id,
            Title = books.Title,
            Description = books.Description,
            Author = books.Author,
            PageCount = books.PageCount
        
        };
        return dto;
    }

    public void Update(BookDto dto)
    {
        Book book = new Book()
        {
            Id = dto.Id,
            Title = dto.Title,
            Description = dto.Description,
            Author = dto.Author,
            PageCount = dto.PageCount,
        };
        bookre.Update(book);
    }
}
