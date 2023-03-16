using Microsoft.Extensions.Options;
using MongoDB.Driver;
using webApiNetCore.Data;
using webApiNetCore.Models;
using webApiNetCore.Repositories;

namespace webApiNetCore.Services
{
    public class DataService : IDataService
    {
        private readonly MongoContext _dbContext;

        public DataService(MongoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IBookRepository Books => new BookRepository(_dbContext.Database);
    }
}
