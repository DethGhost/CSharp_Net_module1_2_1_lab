using System.ComponentModel.Design;

namespace CSharp_Net_module1_2_1_lab
{
    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
    public interface ILibraryUser
    {
        void AddBook(string book);
        void RemoveBook(string book);
        void BookInfo(int index);
        int BooksCount();
    }
}