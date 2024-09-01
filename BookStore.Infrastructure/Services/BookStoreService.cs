using BookStore.Domain.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace BookStore.Infrastructure.Services
{
    public class BookStoreServsice
    {
        private readonly IMongoClient _dbClient;

        public BookStoreServsice(IMongoClient dbClient)
        {
            _dbClient = dbClient;
        }

        public async Task<List<Book>> GetBooks()
        {
            var db = _dbClient.GetDatabase("bookstore");
            var collection = db.GetCollection<Book>("books");
            var books = await collection.Find(new BsonDocument()).ToListAsync();
            return books;
        }

        public Task SaveBook(Book book)
        {
            var db = _dbClient.GetDatabase("bookstore");
            var collection = db.GetCollection<Book>("books");
            return collection.InsertOneAsync(book);
        }

        public Task<Book> GetBookbyId(string bookId)
        {
            var db = _dbClient.GetDatabase("bookstore");
            
            var collection = db.GetCollection<Book>("books");
            
            var filter = Builders<Book>.Filter.Eq("Id", bookId);
            
            return collection.Find(filter).FirstOrDefaultAsync();
        }
    }
}
