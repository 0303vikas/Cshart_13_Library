using src.Interfaces;
namespace src.Product;

public class Novel : Book
{
    public string Genre { get; set; }
    const bool IsBorrowable = true;
    const bool IsPrintable = false;

    public Novel(string title, string author, int isbn, string year, string genre) : base(title, author, isbn, year, IsBorrowable, IsPrintable)
    {
        Genre = genre;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"\nBooks List:\n\nTitle: {Title}, \nGenre: {Genre}, \nAuthor: {Author}, \nISBN: {ISBN}, \nPublicationYear: {PublicationYear},\nBorrowerId:{BorrowerId}, \nBorrowable: {Borrowable}, \nPrintable: {Printable}");
    }
}
