using src.Interfaces;
namespace src.Product;

public class Novel : Book, IBorrowable
{
    public string Genre { get; set; }

    public Novel(string title, string author, int isbn, string year, string genre) : base(title, author, isbn, year, true, false)
    {
        Genre = genre;
    }

    public override void Borrow()
    {
        throw new NotImplementedException();
    }

    public override void Return()
    {
        throw new NotImplementedException();
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"\nBooks List:\n\nTitle: {Title}, \nGenre: {Genre}, \nAuthor: {Author}, \nISBN: {ISBN}, \nPublicationYear: {PublicationYear}, \nBorrowable: {Borrowable}, \nPrintable: {Printable}");

    }
}
