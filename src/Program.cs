using src.BookLibrary;
using src.Product;
using src.User;

Library library = Library.Instance();

// create User 
Customer customer1 = new Customer("Helga", 10);
Customer customer2 = new Customer("bilbin", 11);
Customer customerUpdate = new Customer("UpdatedBilin", 11);

Librarian librarian1 = new Librarian("Employee1", 12838);
Librarian librarian2 = new Librarian("Employee2", 29839);

// add User
Library.AddPerson(customer1);
Library.AddPerson(customer2);

Library.AddPerson(librarian1);
Library.AddPerson(librarian2);

Library.PrintUserList(librarian1.Id);

// creating Books
Comic comic1 = new Comic("Comic1", "Comic1Author", 183747, "June 2023", "Comic1Artist");
Comic comic2 = new Comic("Comic2", "Comic2Author", 183728, "June 2023", "Comic2Artist");
Comic commic2Updated = new Comic("Comic2Updated", "Comic2AuthorUpdated", 183728, "June 2023", "Comic2ArtistUpdated");

Novel novel1 = new Novel("Novel1", "Novel1Author", 183929, "June 2023", "Novel1Genre");
Novel novel2 = new Novel("Novel2", "Novel2Author", 183978, "June 2023", "Novel2Genre");

ResearchPaper researchPaper1 = new ResearchPaper("paper1", "paper1Author", 783923, "June 2023", 100);
ResearchPaper researchPaper2 = new ResearchPaper("paper2", "paper2Author", 783928, "June 2023", 80);

TextBook textBook1 = new TextBook("book1", "book1author", 283928, "June 2023", 400);
TextBook textBook2 = new TextBook("book2", "book2author", 283988, "June 2023", 250);


//Add Books with Librarien id
// Adding Books with user id will give error

Console.WriteLine(library);
Library.Add(comic1, librarian1.Id);
Library.Add(comic2, librarian2.Id);

Library.Add(novel1, librarian1.Id);
Library.Add(novel2, librarian1.Id);

Library.Add(researchPaper1, librarian1.Id);
Library.Add(researchPaper2, librarian1.Id);


Library.Add(textBook1, librarian2.Id);
Library.Add(textBook2, librarian2.Id);

Console.WriteLine(library);

// Borrow Book and Return with Libraray class

Library.Borrow(comic1, customer1.Id);
//Library.Borrow(comic1, customer2.Id); // can't borrow the book, book not available error.
Library.Return(comic1, customer1.Id);

// Borrow and return with customer class
comic1.PrintInfo();
customer1.Borrow(comic1);
comic1.PrintInfo();
customer1.Return(comic1);
comic1.PrintInfo();

//Remove a book
Console.WriteLine(library);
Library.Remove(comic1, librarian1.Id);
Library.Remove(novel1, librarian1.Id);
Console.WriteLine(library);

//Edit a book
Console.WriteLine(library);
Library.Edit(comic2, commic2Updated, librarian1.Id);
Console.WriteLine(library);

////////////// Remove user ////////////////////////////

//old State
Library.PrintUserList(librarian1.Id);

// Remove
// Library.RemovePerson(customer2);

//updated State
Library.PrintUserList(librarian1.Id);

//////////// Update user ////////////////////////

//old State
Library.PrintUserList(librarian1.Id);

// Remove
// Library.EditPerson(customer2, customerUpdate);

//updated State
Library.PrintUserList(librarian1.Id);


















