using src.Product;

namespace src.Interfaces;

public interface IBookModifier
{
    public void Add(Book book);
    public void Remove(Book book);
    public void Edit(Book book, Book updatedBook);
}
