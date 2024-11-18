Library library = new Library("Old Books");
Console.WriteLine($"Welcome to the {library.Name} library");

library.AddBook("Martian");
library.AddBook("Martian");
library.AddBook("Martian");
library.AddBook("Martian");
library.AddBook("Foundation");

Console.WriteLine(library.ListBookInventory());

string borrowedBook = library.BorrowBook("Foundation");
Console.WriteLine(borrowedBook);

Console.WriteLine(library.ListBookInventory());


string borrowedBook2 = library.BorrowBook("Foundation");
Console.WriteLine(borrowedBook2);
