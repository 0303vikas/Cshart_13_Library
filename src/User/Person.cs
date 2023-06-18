using src.Compositions.PersonType;
using src.BookLibrary;
namespace src.User;




// `Person` has properties such as Name and ID. `Customer` and `Librarian` should inherit from this class and have additional properties/features:
//    - `Customer` can Borrow and Return books.
//    - `Librarian` can Add, Remove, Edit books.

public abstract class Person : Library
{
    public string _name { get; set; } = string.Empty;
    private readonly int _id;

    public int Id
    {
        get { return _id; }
    }

    public Person(string name, int id)
    {
        _name = name;
        _id = id;
    }
}

