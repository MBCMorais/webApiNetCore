using Microsoft.AspNetCore.Mvc;
using System.Net;
using webApiNetCore.DTO;
using webApiNetCore.Models;
using webApiNetCore.Repositories;
using webApiNetCore.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webApiNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IBookRepository _db;

        public BooksController(IDataService ds)
        {
            _db = ds.Books;

        }

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _db.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public async Task<Book> GetAsync(string id)
        {

            return await _db.GetBookByIdAsync(id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public async Task PostAsync([FromBody] CreateOrUpdateBookDto model)
        {
          await _db.CreateBookAsync(model);
        }



        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public async Task PutAsync(string id, [FromBody] CreateOrUpdateBookDto model)
        {
            await _db.UpdateBookAsync(id, model);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(string id)
        {
            await _db.DeleteBookAsync(id);
        }
    }
}
