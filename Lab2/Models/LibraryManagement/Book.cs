namespace Lab2.Models.LibraryManagement
{
    public class Book
    {
        public string m_title { get; set; }
        public string m_author { get; set; }
        public string m_publisher { get; set; }

        // Constructor: Initializes a new Book object with a title, author, and publisher
        public Book(string title, string author, string publisher)
        {
            m_title = title;
            m_author = author;
            m_publisher = publisher;
        }

        // Overrides the ToString method to return a formatted string representation of the Book object
        public override string ToString()
        {
            return $"Title: {m_title}, Author: {m_author}, Publisher: {m_publisher}";
        }
    }
    
}
