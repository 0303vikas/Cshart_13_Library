using src.User;
using src.Product;
using System.Text;

namespace src.BookLibrary;

public enum UserType { Customer, Librarian }
public class Library
{
    public static List<Person> Users { get; set; }
    public static List<Book> Books { get; set; }
    private static Library _instance;
    private static readonly object _lockObject = new Object();

    public static Library Instance()
    {
        if (_instance == null)
        {
            lock (_lockObject)
            {
                _instance = new Library();
            }
        }
        return _instance;
    }

    private Library()
    {
        Users = new();
        Books = new();
    }

    public static void Add(Book book, int userId)
    {
        CheckForUserType(userId, UserType.Librarian);

        if (Books.Contains(book)) throw new ArgumentException("Book already Exists.");

        Books.Add(book);
        Console.WriteLine($"Book: {book.Title} Added successfully");
    }

    public static void Remove(Book book, int userId)
    {
        CheckForUserType(userId, UserType.Librarian);

        if (!Books.Contains(book)) throw new ArgumentException("No Book with this name exist.");

        Books.Remove(book);
        Console.WriteLine($"Book: {book.Title} Removed successfully");
    }

    public static void Edit(Book book, Book updatedBook, int userId)
    {
        CheckForUserType(userId, UserType.Librarian);

        if (!Books.Contains(book)) throw new ArgumentException("No Book with this name exist.");

        int findBookIndex = Books.FindIndex(item => item.ISBN == book.ISBN);
        if (findBookIndex != -1) Books[findBookIndex] = updatedBook;
        Console.WriteLine($"Book: {updatedBook.Title} Updated successfully");
    }
    // Book cann't be borrowed or returned from the library instance 
    // Do it from Customer Instance
    public static void Borrow(Book book, int borrowerId)
    {
        CheckForUserType(borrowerId, UserType.Customer);
        if (!Books.Contains(book)) throw new ArgumentException("Book doesn't exist in the database.");
        else if (!book.Borrowable) throw new ArgumentException("This book type cann't be borrowed. Try printing");
        else
        {
            // Id 0 means nobody has borrowed the book
            if (book.BorrowerId != 0) throw new ArgumentException("Book not available.");
            else
            {
                // find book and update borrowerId   
                Book? findBook = Books.FirstOrDefault(item => item == book);
                if (findBook != null) findBook.AddBorrowerId(borrowerId);
                Console.Write($"Book: {book.Title} borrowed successfully. Return period is 7 days.\n");
            }
        }
    }

    public static void Return(Book book, int borrowerId)
    {
        CheckForUserType(borrowerId, UserType.Customer);
        if (!Books.Contains(book)) throw new ArgumentException("Book doesn't exist in the database.");
        else if (book.BorrowerId == 0) throw new ArgumentException("This book was never borrowed.");
        else
        {
            // find book and update borrowerId
            Book? findBook = Books.FirstOrDefault(item => item == book);
            if (findBook != null) findBook.ResetBorrowerId();
            Console.Write($"Book: {book.Title} returned successfully. Hope you enjoyed it.\n");
        }
    }

    public static void AddPerson(Person person)
    {
        if (Users.Contains(person)) throw new ArgumentException("Person already exist's in the database.");
        else
        {
            Users.Add(person);
            Console.WriteLine($"{person.Name}: Added Successfully to database");
        }
    }

    public static void RemovePerson(Person person)
    {
        if (!Users.Contains(person)) throw new ArgumentException("No Person found in the database.");
        else
        {
            Users.Remove(person);
            Console.WriteLine("Person Remove Successfully");
        }
    }

    public static void EditPerson(Person person, Person updatedPerson)
    {
        if (!Users.Contains(person)) throw new ArgumentException("No Person found in the database.");
        else
        {
            int findPersonIndex = Users.FindIndex(item => item.Id == person.Id);
            if (findPersonIndex != -1) Users[findPersonIndex] = updatedPerson;
            Console.WriteLine($"Person {person.Name} Updated Successfully");
        }
    }

    private static void CheckForUserType(int userId, UserType userType)
    {
        var findUser = Users.Find(person => person.Id == userId);
        if (findUser == null) throw new ArgumentException("User with userId doesn't exist"); // check Users list
        // user check for borrowiing and return books
        if (userType == UserType.Customer && (findUser is not Customer)) throw new ArgumentException("Only Customers can borrow books");
        // user check for adding, removing and editing books       
        if (userType == UserType.Librarian && (findUser is not Librarian)) throw new ArgumentException("Only Librarians can add a book.");
    }

    public static void PrintUserList(int userId)
    {
        CheckForUserType(userId, UserType.Librarian);
        StringBuilder printString = new StringBuilder("Library Store Users: - \n\n");
        foreach (var user in Users)
        {
            printString.Append($"UserId: {user.Id}, UserName {user.Name}\n");
        }
        Console.WriteLine(printString.ToString());
    }

    public override string ToString()
    {
        StringBuilder printString = new StringBuilder("Library Store Books: - \n\n");
        foreach (var book in Books)
        {
            printString.Append($"Title: {book.Title}, Author {book.Author}, ISBN: {book.ISBN}, Borrowable: {book.Borrowable}, Printable: {book.Printable} \n");
        }

        return printString.ToString();
    }
}


