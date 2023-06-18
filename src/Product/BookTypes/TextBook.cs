using src.Interfaces;
namespace src.Product;

public class TextBook : Book, IBorrowable, IPrintable
{
    public int Pages { get; set; }
    public TextBook(string title, string author, int isbn, string year, int pages) : base(title, author, isbn, year, true, true)
    {
        Pages = pages;
    }

    public override void Borrow()
    {
        throw new NotImplementedException();
    }

    public void PrintPages(int startPage, int endPage)
    {
        if (startPage < 0)
        {
            /// throw neww error can't be negative
        }
        else if (endPage > Pages)
        {
            /// throw new out of limit
        }
        Console.WriteLine($"Printing Pages from {startPage} to {endPage}");
    }

    public override void Return()
    {
        throw new NotImplementedException();
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
    }
}
