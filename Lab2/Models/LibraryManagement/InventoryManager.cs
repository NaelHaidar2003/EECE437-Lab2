using System.Collections.Generic;

namespace Lab2.Models.LibraryManagement
{
    public class InventoryManager
    {
        private List<Book> m_books;
        public InventoryManager()
        {
            m_books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            m_books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            m_books.Remove(book);
        }

        public List<Book> GetBooks()
        {
            return m_books;
        }
        public void ListBooks()
        {
            if (m_books.Count == 0)
            {
                System.Console.WriteLine("No books in inventory");
            }
            else
            {
                foreach(Book book in m_books)
                {
                    System.Console.WriteLine(book);
                }
            }
        }
    }
}