using src.Interfaces;
namespace src.Product;

public class ResearchPaper : Book, IPrintable
{
    public int Pages { get; set; }
    const bool IsBorrowable = false;
    const bool IsPrintable = true;

    public ResearchPaper(string title, string author, int isbn, string year, int pages) : base(title, author, isbn, year, IsBorrowable, IsPrintable)
    {
        Pages = pages;
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

    public override void PrintInfo()
    {
        base.PrintInfo();
    }
}
