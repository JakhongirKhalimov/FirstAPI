using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.BL.DTOs;
using WebApplication1.BL.Services;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController(IBookService bookService) : ControllerBase
{
    private readonly IBookService _bookService = bookService;
    [HttpPost]
    public IActionResult Create([FromForm] AddBookDto dto)
    {
        _bookService.Create(dto);
        return Ok();
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_bookService.GetAll());
    }
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(_bookService.GetById(id));
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _bookService.Delete(id);
        return Ok();
    }
    [HttpPut]
    public IActionResult Update(BookDto book)
    {
        _bookService.Update(book);
        return Ok();
    }
}
