using src.User;
namespace src.Compositions.PersonType;


public class Librarian : Person
{
    public Librarian(string name, int id) : base(name, id) { }

    public override void AddBook() { }

    public override void RemoveBook() { }

    public override void EditBook() { }

}




