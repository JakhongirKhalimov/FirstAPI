using WebApplication1.BL.DTOs;

namespace WebApplication1.BL.Services;

public interface IBookService
{
    List<BookDto> GetAll();
    BookDto GetById(int id);
    void Create(AddBookDto dto);
    void Update(BookDto dto);
    void Delete(int  id);
}
