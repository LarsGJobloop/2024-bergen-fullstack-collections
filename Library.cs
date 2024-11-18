// Library.cs
// This class represents a library that can manage books and their availability.
class Library
{
  // Public field to store the name of the library
  public string Name;

  // A dictionary to track how many copies of each book are in the library
  // Why a Dictionary? 
  // - The key (book title) allows us to quickly look up specific books.
  // - The value (number of copies) lets us efficiently track the quantity of each book.
  private Dictionary<string, int> bookInventory;

  // A dictionary to track how many copies of each book have been lent out
  // Why another Dictionary?
  // - It complements the inventory by letting us monitor borrowed copies separately.
  // - Together, these two dictionaries provide a clear way to manage the library's books.
  private Dictionary<string, int> lentOutBooks;

  // Constructor: Initializes the library with a name and sets up empty dictionaries for book tracking
  public Library(string name)
  {
    Name = name; // Set the library's name
    bookInventory = new Dictionary<string, int>(); // Initialize the book inventory
    lentOutBooks = new Dictionary<string, int>(); // Initialize the lent-out tracker
  }

  // Method to add a book to the library
  public void AddBook(string title)
  {
    // Check if the book is already in the inventory
    if (bookInventory.ContainsKey(title))
    {
      // If the book is already in the inventory, increase its count
      bookInventory[title] = bookInventory[title] + 1;
    }
    else
    {
      // If the book is new, add it to both the inventory and lent-out tracker with initial counts
      bookInventory.Add(title, 1);
      lentOutBooks.Add(title, 0);
    }
  }

  // Method to list all books in the library's inventory
  public string ListBookInventory()
  {
    // Start building the inventory string
    string inventoryString = "Inventory:";

    // Loop through all books in the inventory
    foreach (var (title, amount) in bookInventory)
    {
      // Add each book's details to the string
      inventoryString +=
        $"\nTitle: {title}\tAmount: {amount}\tLent Out: {lentOutBooks[title]}";
    }

    // Return the final inventory string
    return inventoryString;
  }

  // Method to borrow a book from the library
  public string BorrowBook(string title)
  {
    // Try to get the total number of books and the number lent out for the given title
    bookInventory.TryGetValue(title, out int bookTotal);
    lentOutBooks.TryGetValue(title, out int lentOut);

    // Check if there are more books available than already lent out
    if (bookTotal > lentOut)
    {
      // If so, lend out one more copy and return the book title
      lentOutBooks[title] = lentOutBooks[title] + 1;
      return title;
    }
    else
    {
      // If not, indicate that no books are available to borrow
      return "No available books to borrow";
    }
  }
}
