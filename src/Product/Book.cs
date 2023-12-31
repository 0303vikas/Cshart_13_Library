using System.Text;
using src.BookLibrary;
using src.Interfaces;

namespace src.Product;

// `Book` has properties like Title, Author, ISBN, PublicationYear, CanBorrow, and CanPrint.To simplify the logic, we can consider each book an unique record with unique ISBN in the `Library`. In addition, `Book` has `PrintInfo()` method to print information about each book(uses `Console.WriteLine`). `Comic`, `Novel`, `TextBook`, and `ResearchPaper`should inherit properties from `Book` and have additional properties/features:
//    - `Comic` has `Artist`, `Novel` has `Genre`
//    - `Comic`, `Novel`, `TextBook` can be borrowed, but `ResearchPaper` cannot.If books are borrowable, they should have both `Borrow()` and `Return()` method
//    - `TextBook`, and `ResearchPaper` can be printed(to certain amount of pages), but `Comic`, `Novel` cannot.The `PrintPages(int startPage, endPage)`method uses `Console.WriteLine` to inform the start page and end page to be printed, in case the amount of to-be-printed pages do not exceed the maximum allowed pages.
//    - `Comic`and `Novel` should have different implementations of `PrintInfo()` with extra information about the extra properties, while `TextBook`, and `ResearchPaper` have default implementation.


public abstract class Book : IBorrowable
{
    public string Title;
    public string Author;
    public int ISBN;
    public string PublicationYear;
    public bool Borrowable;
    public bool Printable;

    private int _borrowerId = 0; // Initial zero, means not borrowed
    public int BorrowerId
    {
        get { return _borrowerId; }
        set { _borrowerId = value; }
    }

    public Book(string title, string author, int isbn, string year, bool borrowable, bool printable)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = year;
        Borrowable = borrowable;
        Printable = printable;
    }

    public void AddBorrowerId(int id)
    {
        if (_borrowerId != 0) throw new Exception("Book already Borrowed.");
        BorrowerId = id;
    }

    public void ResetBorrowerId()
    {
        if (_borrowerId == 0) throw new Exception("Book never Borrowed.");
        BorrowerId = 0;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"\nBooks List:\n\nTitle: {Title}, \nAuthor: {Author}, \nISBN: {ISBN}, \nPublicationYear: {PublicationYear}, \nBorrowable: {Borrowable}, \nPrintable: {Printable}");
    }


}
