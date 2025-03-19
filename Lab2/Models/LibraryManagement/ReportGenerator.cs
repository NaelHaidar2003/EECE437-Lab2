namespace Lab2.Models.LibraryManagement
{
    public class ReportGenerator
    {
        public void booksByAuthor(string author, List<Book> books)
        {
            foreach(Book book in books)
            {
                if(book.m_author == author)
                {
                    System.Console.WriteLine(book);
                }
            }
        }

        public void authorWithMostBooks(List<Book> books)
        {
            Dictionary<string, int> authorBookCount = new Dictionary<string, int>();
            foreach(Book book in books)
            {
                if(authorBookCount.ContainsKey(book.m_author))
                {
                    authorBookCount[book.m_author]++;
                }
                else
                {
                    authorBookCount[book.m_author] = 1;
                }
            }
            int max = authorBookCount.Values.Max();
            foreach(KeyValuePair<string, int> entry in authorBookCount)
            {
                if(entry.Value == max)
                {
                    System.Console.WriteLine(entry.Key);
                }
            }
        }
    }
}