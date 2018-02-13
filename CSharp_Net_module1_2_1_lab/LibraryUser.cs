using System;

namespace CSharp_Net_module1_2_1_lab
{
    // 2) declare class LibraryUser, it implements ILibraryUser

    class LibraryUser : ILibraryUser
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;

        private int bookLimit;

        // 4) declare field (bookList) as a string array
        private string[] bookList;

        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)
        public int Id => id;

        public string FirstName => firstName;

        public string LastName => lastName;

        public int BookLimit => bookLimit;

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        // 5) declare indexer BookList for array bookList
        public string this[int index]
        {
            get { return bookList[index]; }
            set { bookList[index] = value; }
        }


        // 6) declare constructors: default and parameter
        public LibraryUser()
        {
            bookLimit = 2;
            bookList = new string[bookLimit];
        }

        public LibraryUser(string firstName, string lastName, string phone, int bookLimit)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.bookLimit = bookLimit;
            bookList = new string[bookLimit];
        }

        // 7) declare methods: 
        //AddBook() – add new book to array bookList
        public void AddBook(string book)
        {
            if(!IsBookInList(book))
            for (int i = 0; i < bookLimit; i++)
            {
                if (bookList[i] == null)
                {
                    bookList[i] = book;
                    Console.WriteLine("You added {0} to {1} {2} book list.", book, lastName, firstName);
                    break;
                }
                else
                {
                    if (i + 1 == bookLimit)
                    {
                        Console.WriteLine("Your book list is full. First you need to remove one other from list.\n" +
                                          "If you want to remove other book from list enter 1, for exit enter any key");
                        string con = Console.ReadLine();
                        if (con == "1")
                        {
                            RemoveBook();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("This book already in your list");
            }
        }

        //RemoveBook() – remove book from array bookList
        public void RemoveBook(string book)
        {
            if (IsBookInList(book))
            {
                for (int i = 0; i < bookLimit; i++)
                {
                    if (bookList[i] == book)
                    {
                        bookList[i] = null;
                        Console.WriteLine("Book {0} succesfuly deleted from list", book);
                    }
                }
            }
            else
            {
                Console.WriteLine("There no book with that name");
            }
        }

        public void RemoveBook()
        {
            int i = 0;
            Console.WriteLine("Your book list contents this books:");
            foreach (var bookInList in bookList)
            {
                Console.WriteLine("{0} - {1}", (i + 1), bookInList);
                i++;
            }

            Console.WriteLine("Enter book number to delete");
            string bookNumber = Console.ReadLine();
            int n;

            if (int.TryParse(bookNumber, out n) && n <= bookLimit && n >= 0)
            {
                Console.WriteLine("You delete {0} from book list", bookList[n - 1]);
                bookList[n - 1] = null;
            }
            else
            {
                Console.WriteLine("You enter wrong number");
                RemoveBook();
            }
        }

        //BookInfo() – returns book info by index
        public void BookInfo(int index)
        {
            if (index <= index && index >= 0)
            {
                Console.WriteLine("Book with index {0} is - {1}", index, bookList[index - 1]);
            }
            else
            {
                int ind;
                do
                {
                    Console.WriteLine("You enter wrong index, try again");
                    Console.WriteLine("Enter index");
                } while (int.TryParse(Console.ReadLine(), out ind));

                BookInfo(ind);
            }
        }

        //BooksCout() – returns current count of books
        public int BooksCount()
        {
            int n = 0;
            foreach (var book in bookList)
            {
                if (book != null)
                {
                    n++;
                }
            }

            Console.WriteLine("you have {0} books", n);
            return n;
        }

        public bool IsBookInList(string book)
        {
            foreach (var bookInList in bookList)
            {
                if (bookInList == book)
                {
                    return true;
                }
            }

            return false;
        }
    }
}