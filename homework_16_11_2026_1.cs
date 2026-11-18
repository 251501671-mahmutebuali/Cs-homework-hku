using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    private int pages;

    public int Pages
    {
        get { return pages; }
        set
        {
            if (value > 0)
            {
                pages = value;
            }
            else
            {
                throw new ArgumentException("Pages must be greater than 0.");
            }
        }
    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public string Info()
    {
        return $"{Title} by {Author}, {Pages} pages";
    }
}

class Program
{
    static void Main()
    {
        Book[] books =
        {
            new Book("Suç ve Ceza", "Dostoyevski", 687),
            new Book("The Hobbit", "Tolkien", 310),
            new Book("1984", "George Orwell", 328)
        };

        foreach (Book book in books)
        {
            Console.WriteLine(book.Info());
        }

        Book mostPages = books[0];

        foreach (Book book in books)
        {
            if (book.Pages > mostPages.Pages)
            {
                mostPages = book;
            }
        }

        Console.WriteLine("Book with the most pages: " + mostPages.Info());
    }
}
