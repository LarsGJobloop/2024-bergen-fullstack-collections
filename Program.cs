// This is the entry point of our program.
// We're simulating a library system where we can add books, borrow them, and see the inventory.

// Create a new library named "Old Books"
Library library = new Library("Old Books");
Console.WriteLine($"Welcome to the {library.Name} library"); // Greet the user with the library's name

// Add books to the library
library.AddBook("Martian"); // Add 4 copies of "Martian"
library.AddBook("Martian");
library.AddBook("Martian");
library.AddBook("Martian");
library.AddBook("Foundation"); // Add 1 copy of "Foundation"

// Display the current inventory of books in the library
Console.WriteLine(library.ListBookInventory());

// Borrow a book titled "Foundation" from the library
// This reduces the available stock of "Foundation" by 1
string borrowedBook = library.BorrowBook("Foundation");
Console.WriteLine(borrowedBook); // Show which book (if any) was borrowed

// Display the updated inventory after borrowing a book
Console.WriteLine(library.ListBookInventory());

// Try to borrow another copy of "Foundation"
// Since there was only one copy, this should return an error message
string borrowedBook2 = library.BorrowBook("Foundation");
Console.WriteLine(borrowedBook2); // Display the result of the second borrowing attempt
