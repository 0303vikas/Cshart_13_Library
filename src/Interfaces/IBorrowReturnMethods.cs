using src.Product;
using src.User;

namespace src.Interfaces;
public interface IBorrowReturnMethods
{
    public void Borrow(Book book);
    public void Return(Book book);
}
