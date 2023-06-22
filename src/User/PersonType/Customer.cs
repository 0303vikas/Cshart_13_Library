using src.BookLibrary;
using src.Interfaces;
using src.Product;
namespace src.User;

public class Customer : Person, IBorrowReturnMethods
{
    private List<Book> _borrowedBooks;

    public List<Book> BorrowedBooks
    {
        get { return _borrowedBooks; }
        set { _borrowedBooks = value; }
    }

    public Customer(string name, int id) : base(name, id)
    {
        _borrowedBooks = new();
    }

    public void Borrow(Book book)
    {
        Library.Borrow(book, Id);
        _borrowedBooks.Add(book);
    }

    public void Return(Book book)
    {
        Library.Return(book, Id);
        _borrowedBooks.Remove(book);
    }
}
