using src.Interfaces;
namespace src.Product;

public class Comic : Book, IBorrowable
{
    public string Artist { get; set; }

    public Comic(string title, string author, int isbn, string year, string artist) : base(title, author, isbn, year, true, false)
    {
        Artist = artist;
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
        Console.WriteLine($"\nBooks List:\n\nTitle: {Title}, \nAuthor: {Author}, \nArtist: {Artist}, \nISBN: {ISBN}, \nPublicationYear: {PublicationYear}, \nBorrowable: {Borrowable}, \nPrintable: {Printable}");
    }
}
