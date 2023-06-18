using src.User;
using src.Product;

namespace src.BookLibrary;
// 1. `Library` should manage the collection of Book objects, and `Person` objects.This class should have following methods:
//    - Add, Remove, Borrow, and Return books
//    - Add, Remove, Edit `Person` objects
public class Library
{
    private List<Person> _users { get; set; }
    private List<Book> _books;

    public Library()
    {
        _users = new List<Person>();
        _books = new List<Book>();
    }

    public Library(Person person) : this()
    {
        _users.Add(person);

    }

    public Library(Book book) : this()
    {
        _books.Add(book);
    }

    public virtual void AddBook()
    {

    }

    public virtual void RemoveBook()
    {

    }

    public virtual void BorrowBook()
    {

    }

    public virtual void ReturnBook()
    {

    }

    public virtual void EditBook() { }


    public virtual void AddPerson()
    {

    }

    public virtual void RemovePerson()
    {

    }

    public virtual void EditPerson()
    {

    }

    public override string ToString()
    {
        return base.ToString();
    }
}


