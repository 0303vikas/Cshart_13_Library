using src.User;
namespace src.Compositions.PersonType;

public class Customer : Person
{

    public Customer(string name, int id) : base(name, id) { }

    public override void BorrowBook()
    {
    }

    public override void ReturnBook() { }
}
