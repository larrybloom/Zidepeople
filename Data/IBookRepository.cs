using BookManagementAPI.Models;

namespace BookManagementAPI.Data
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        Book Add(Book book);
        bool Update(int id, Book updateBook);
        bool Delete(int id);
    }
}
