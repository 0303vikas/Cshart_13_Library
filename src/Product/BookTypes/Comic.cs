using src.Interfaces;
namespace src.Product;

public class Comic : Book
{
    public string Artist { get; set; }

    const bool IsBorrowable = true;
    const bool IsPrintable = false;

    public Comic(string title, string author, int isbn, string year, string artist) : base(title, author, isbn, year, IsBorrowable, IsPrintable)
    {
        Artist = artist;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"\nBooks List:\n\nTitle: {Title}, \nGenre: {Artist}, \nAuthor: {Author}, \nISBN: {ISBN}, \nPublicationYear: {PublicationYear}, \nBorrowerId:{BorrowerId}, \nBorrowable: {Borrowable}, \nPrintable: {Printable}");
    }
}
