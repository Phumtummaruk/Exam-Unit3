using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Book
{
    public string Title { get; set; }
    public int PublicationYear { get; set; }
    public string Author { get; set; }
    public string Isbn { get; set; }
}

public class MyBooksTheyAreAMess
{
    public static List<Book> FilterBooksByTitleStartingWithThe(List<Book> books)
    {
        List<Book> filteredBooks = new List<Book>();
        foreach (var book in books)
        {
            if (book.Title.StartsWith("The"))
            {
                filteredBooks.Add(book);
            }
        }
        return filteredBooks;
    }

    public static List<Book> FilterBooksByAuthorNameContainsT(List<Book> books)
    {
        List<Book> filteredBooks = new List<Book>();
        foreach (var book in books)
        {
            if (book.Author.ToLower().Contains("t"))
            {
                filteredBooks.Add(book);
            }
        }
        return filteredBooks;
    }

    public static int CountBooksPublishedAfterYear(List<Book> books, int year)
    {
        int count = 0;
        foreach (var book in books)
        {
            if (book.PublicationYear > year)
            {
                count++;
            }
        }
        return count;
    }

    public static int CountBooksPublishedBeforeYear(List<Book> books, int year)
    {
        int count = 0;
        foreach (var book in books)
        {
            if (book.PublicationYear < year)
            {
                count++;
            }
        }
        return count;
    }

    public static List<string> GetIsbnNumbersByAuthor(List<Book> books, string author)
    {
        List<string> isbns = new List<string>();
        foreach (var book in books)
        {
            if (book.Author.Equals(author))
            {
                isbns.Add(book.Isbn);
            }
        }
        return isbns;
    }

    public static List<Book> SortBooksAlphabeticallyAscending(List<Book> books)
    {
        books.Sort((a, b) => string.Compare(a.Title, b.Title, StringComparison.Ordinal));
        return books;
    }

    public static List<Book> SortBooksAlphabeticallyDescending(List<Book> books)
    {
        books.Sort((a, b) => string.Compare(b.Title, a.Title, StringComparison.Ordinal));
        return books;
    }

    public static List<Book> SortBooksChronologicallyAscending(List<Book> books)
    {
        books.Sort((a, b) => a.PublicationYear.CompareTo(b.PublicationYear));
        return books;
    }

    public static List<Book> SortBooksChronologicallyDescending(List<Book> books)
    {
        books.Sort((a, b) => b.PublicationYear.CompareTo(a.PublicationYear));
        return books;
    }

    public static Dictionary<string, List<Book>> GroupBooksByAuthorLastName(List<Book> books)
    {
        Dictionary<string, List<Book>> groupedBooks = new Dictionary<string, List<Book>>();
        foreach (var book in books)
        {
            string[] authorName = book.Author.Split(' ');
            string lastName = authorName[authorName.Length - 1];
            if (!groupedBooks.ContainsKey(lastName))
            {
                groupedBooks[lastName] = new List<Book>();
            }
            groupedBooks[lastName].Add(book);
        }
        return groupedBooks;
    }

    public static Dictionary<string, List<Book>> GroupBooksByAuthorFirstName(List<Book> books)
    {
        Dictionary<string, List<Book>> groupedBooks = new Dictionary<string, List<Book>>();
        foreach (var book in books)
        {
            string[] authorName = book.Author.Split(' ');
            string firstName = authorName[0];
            if (!groupedBooks.ContainsKey(firstName))
            {
                groupedBooks[firstName] = new List<Book>();
            }
            groupedBooks[firstName].Add(book);
        }
        return groupedBooks;
    }

    public static void Main(string[] args)
    {
        string json = File.ReadAllText("books.json");
        List<Book> books = JsonSerializer.Deserialize<List<Book>>(json);


        List<Book> booksStartingWithThe = FilterBooksByTitleStartingWithThe(books);
        List<Book> booksWithAuthorNameContainsT = FilterBooksByAuthorNameContainsT(books);
        int countBooksAfter1992 = CountBooksPublishedAfterYear(books, 1992);
        int countBooksBefore2004 = CountBooksPublishedBeforeYear(books, 2004);
        List<string> isbns = GetIsbnNumbersByAuthor(books, "Terry Pratchett");
        List<Book> booksSortedAlphabeticallyAscending = SortBooksAlphabeticallyAscending(books);
        List<Book> booksSortedAlphabeticallyDescending = SortBooksAlphabeticallyDescending(books);
        List<Book> booksSortedChronologicallyAscending = SortBooksChronologicallyAscending(books);
        List<Book> booksSortedChronologicallyDescending = SortBooksChronologicallyDescending(books);
        Dictionary<string, List<Book>> booksGroupedByAuthorLastName = GroupBooksByAuthorLastName(books);
        Dictionary<string, List<Book>> booksGroupedByAuthorFirstName = GroupBooksByAuthorFirstName(books);
    }
}