using System.Collections.Generic;

namespace Lab2.Models.LibraryManagement
{
    // The InventoryManager class is responsible solely for managing the book inventory.
    // This complies with the Single Responsibility Principle (SRP) as it handles only one responsibility: managing the collection of Book objects.
    public class InventoryManager
    {
        // Private list to store Book objects.
        private List<Book> m_books;

        // Constructor: Initializes a new InventoryManager with an empty list of books.
        public InventoryManager()
        {
            m_books = new List<Book>();
        }

        // Adds a Book to the inventory.
        public void AddBook(Book book)
        {
            m_books.Add(book);
        }

        // Removes a Book from the inventory.
        public void RemoveBook(Book book)
        {
            m_books.Remove(book);
        }

        // Returns the current list of books.
        public List<Book> GetBooks()
        {
            return m_books;
        }

        // Displays all books in the inventory.
        // If there are no books, it informs the user that the inventory is empty.
        public void ListBooks()
        {
            if (m_books.Count == 0)
            {
                System.Console.WriteLine("No books in inventory");
            }
            else
            {
                foreach (Book book in m_books)
                {
                    System.Console.WriteLine(book);
                }
            }
        }
    }
}
// In this code, the InventoryManager class adheres to the Single Responsibility Principle because it focuses exclusively 
// on managing book objects (adding, removing, retrieving, and listing books), 
// without mixing any unrelated responsibilities.