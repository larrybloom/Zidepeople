using BookManagementAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookManagementAPI.Data
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books = new List<Book>();
        private int _nextId = 1;

        public IEnumerable<Book> GetAll() 
        {
            Console.WriteLine($"Retriving all books. Total count : {_books.Count}");
            return _books;
        }

        public Book GetById(int id) => _books.FirstOrDefault(b => b.Id == id);

        public Book Add(Book book)
        {
            book.Id = _nextId++;
            _books.Add(book);
            Console.WriteLine($"Book Added: {book.Title}, {book.Author}, {book.PublishedYear}");
            return book;
        }

        public bool Update(int id, Book updateBook)
        {
            var existingBook = _books.FirstOrDefault(b => b.Id == id);

            if (existingBook == null) return false;

            existingBook.Title = updateBook.Title;
            existingBook.Author = updateBook.Author;
            existingBook.PublishedYear = updateBook.PublishedYear;

            return true;
        }

        public bool Delete(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book == null) return false;

            _books.Remove(book);
            return true;
        }
    }
}
