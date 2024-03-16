namespace WebApplication1.Data.Repository;

public interface IBookRespository
{
    List<Book> GetAll();
    Book GetById(int id);
    void Create(Book book);
    void Update(Book book); 

    void Delete(Book book);
}
