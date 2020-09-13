using BookApi.BL;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Test()
        {
            return new OkObjectResult("test");
            return new OkObjectResult("test");
        }
    }
}