using src.BookLibrary;
namespace src.User;

public abstract class Person
{
    private string _name { get; set; } = string.Empty;
    private readonly int _id;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

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

