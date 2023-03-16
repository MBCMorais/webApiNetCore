using webApiNetCore.DTO;
using webApiNetCore.Models;

namespace webApiNetCore.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<Book> GetBookByIdAsync(string bookId);
        Task<Book> GetBookByNameAsync(string bookName);
        Task CreateBookAsync(CreateOrUpdateBookDto model);
        Task<Book> UpdateBookAsync(string id,CreateOrUpdateBookDto model);
        Task DeleteBookAsync(string id);
        
        

    }
}
