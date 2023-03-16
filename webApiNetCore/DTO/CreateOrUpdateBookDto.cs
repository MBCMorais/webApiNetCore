

using webApiNetCore.Models;

namespace webApiNetCore.DTO
{
    public class CreateOrUpdateBookDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        public string AuthorName { get; set; }

        //public IEnumerable<Author>? Authors { get; set; }

        //public IEnumerable<Category>? Categories { get; set; }


    }
}
