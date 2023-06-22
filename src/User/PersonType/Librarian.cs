using src.BookLibrary;
using src.Interfaces;
using src.Product;
namespace src.User;

public class Librarian : Person, IBookModifier
{
    public Librarian(string name, int id) : base(name, id) { }

    public void Add(Book book)
    {
        Library.Add(book, Id);
    }

    public void Remove(Book book)
    {
        Library.Remove(book, Id);
    }

    public void Edit(Book book, Book updatedBook)
    {
        Library.Edit(book, updatedBook, Id);
    }
}




