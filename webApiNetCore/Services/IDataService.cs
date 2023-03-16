using webApiNetCore.Repositories;

namespace webApiNetCore.Services
{
    public interface IDataService
    {
        public IBookRepository Books { get; }
    }
}
