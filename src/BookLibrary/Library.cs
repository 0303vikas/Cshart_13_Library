using src.User;
using src.Product;

namespace src.BookLibrary;
// 1. `Library` should manage the collection of Book objects, and `Person` objects.This class should have following methods:
//    - Add, Remove, Borrow, and Return books
//    - Add, Remove, Edit `Person` objects
public class Library
{
    public List<Person> Users { get; set; }
    public List<Book> Books;



    public Library()
    {
        Users = new List<Person>();
        Books = new List<Book>();
    }

    public Library(Person person) : this()
    {
        Users.Add(person);

    }

    public Library(Book book) : this()
    {
        Books.Add(book);
    }

    public virtual void Add()
    {

    }

    public virtual void Remove()
    {

    }

    public virtual void Borrow()
    {

    }

    public virtual void Return()
    {

    }

    public virtual void Edit() { }


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


