using System;
using System.Collections;

public class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        library.AddNewBook("Folwark Zwierzęcy", "George Orwell", "2000");
        library.DisplayAllBooks();
        Console.ReadKey();
    }
}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublicationYear { get; set; }

    public Book(string title, string author, string publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }

    public override string ToString()
    {
        return $"Title: {Title}, Author: {Author}, Publication Year: {PublicationYear}";
    }
}

public class Library
{
    private ArrayList listOfBooks = new ArrayList();

    public void AddNewBook(string title, string author, string publicationYear)
    {
        listOfBooks.Add(new Book(title, author, publicationYear));
    }

    public void RemoveBook()
    {
        // Implementacja usuwania książek
    }

    public void DisplayAllBooks()
    {
        foreach (var book in listOfBooks)
        {
            Console.WriteLine(book);
        }
    }
}
