using System.Collections.Generic;
using System.Linq; // Required for the Max() method

namespace Lab2.Models.LibraryManagement
{
    // The ReportGenerator class is responsible solely for generating reports related to books and authors.
    // This adheres to the Single Responsibility Principle (SRP) as it only handles report generation, separate from inventory management or book handling.
    public class ReportGenerator
    {
        // Prints all books written by a specific author.
        // Iterates through the book list and checks if the author's name matches the given parameter.
        public void booksByAuthor(string author, List<Book> books)
        {
            foreach (Book book in books)
            {
                if (book.m_author == author)
                {
                    System.Console.WriteLine(book);
                }
            }
        }

        // Determines and prints the author with the most books in the given list.
        // Uses a dictionary to count the number of books per author.
        public void authorWithMostBooks(List<Book> books)
        {
            Dictionary<string, int> authorBookCount = new Dictionary<string, int>();

            // Count the number of books for each author.
            foreach (Book book in books)
            {
                if (authorBookCount.ContainsKey(book.m_author))
                {
                    authorBookCount[book.m_author]++;
                }
                else
                {
                    authorBookCount[book.m_author] = 1;
                }
            }

            // Find the maximum number of books by a single author.
            int max = authorBookCount.Values.Max();

            // Print all authors who have the maximum number of books.
            foreach (KeyValuePair<string, int> entry in authorBookCount)
            {
                if (entry.Value == max)
                {
                    System.Console.WriteLine(entry.Key);
                }
            }
        }
    }
}
