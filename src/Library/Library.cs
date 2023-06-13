namespace Library;


// 1. `Library` should manage the collection of Book objects, and `Person` objects.This class should have following methods:
//    - Add, Remove, Borrow, and Return books
//    - Add, Remove, Edit `Person` objects
public class Library
{
    private List<Person> _users;
    private List<Book> _books;

    private Library()
    {

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
