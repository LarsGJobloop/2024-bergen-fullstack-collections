class Library
{
  public string Name;

  private Dictionary<string, int> bookInventory;
  private Dictionary<string, int> lentOutBooks;

  public Library(string name)
  {
    Name = name;
    bookInventory = new Dictionary<string, int>();
    lentOutBooks = new Dictionary<string, int>();
  }

  public void AddBook(string title)
  {
    if (bookInventory.ContainsKey(title))
    {
      bookInventory[title] = bookInventory[title] + 1;
    }
    else
    {
      bookInventory.Add(title, 1);
      lentOutBooks.Add(title, 0);
    }
  }

  public string ListBookInventory()
  {
    string inventoryString = "Inventory:";

    foreach (var (title, amount) in bookInventory)
    {
      inventoryString +=
        $"\nTitle: {title}\tAmount: {amount}\tLent Out: {lentOutBooks[title]}";
    }

    return inventoryString;
  }

  public string BorrowBook(string title)
  {
    bookInventory.TryGetValue(title, out int bookTotal);
    lentOutBooks.TryGetValue(title, out int lentOut);

    if (bookTotal > lentOut)
    {
      lentOutBooks[title] = lentOutBooks[title] + 1;
      return title;
    }
    else
    {
      return "No available books to borrow";
    }
  }
}