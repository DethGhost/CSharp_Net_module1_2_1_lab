//using System;
//
//namespace CSharp_Net_module1_2_1_lab
//{
//    // 1) declare interface ILibraryUser
//    // declare method's signature for methods of class LibraryUser
//
//
//    // 2) declare class LibraryUser, it implements ILibraryUser
//
//    class LibraryUser : ILibraryUser
//    {
//        private int id;
//        private string firstName;
//        private string lastName;
//        private string phone;
//        private string[] bookList;
//
//        public int Id => id;
//
//        public string FirstName => firstName;
//
//        public string LastName => lastName;
//
//       private int bookLimit;
//        
//        public int BookLimit => bookLimit;
//
//        public string this[int index]
//        {
//            get { return bookList[index]; }
//            set { bookList[index] = value; }
//        }
//
//        public string Phone
//        {
//            get => phone;
//            set => phone = value;
//        }
//
//        public LibraryUser()
//        {
//        }
//
//        public LibraryUser(int id, string firstName, string lastName, string phone, string[] bookList, int bookLimit)
//        {
//            this.id = id;
//            this.firstName = firstName;
//            this.lastName = lastName;
//            this.phone = phone;
//            this.bookList = bookList;
//            this.bookLimit = bookLimit;
//        }
//
//
//        public void AddBook(string book)
//        {
//            this[book];
//        }
//
//        public void RemoveBook()
//        {
//            throw new NotImplementedException();
//        }
//
//        public void BookInfo()
//        {
//            throw new NotImplementedException();
//        }
//
//        public int BooksCout()
//        {
//            return bookList.Length;
//        }
//    }
//
//    // 3) declare properties: FirstName (read only), LastName (read only), 
//    // Id (read only), Phone (get and set), BookLimit (read only)
//
//    // 4) declare field (bookList) as a string array
//
//
//    // 5) declare indexer BookList for array bookList
//
//    // 6) declare constructors: default and parameter
//
//    // 7) declare methods: 
//
//    //AddBook() – add new book to array bookList
//
//    //RemoveBook() – remove book from array bookList
//
//    //BookInfo() – returns book info by index
//
//    //BooksCout() – returns current count of books
//}