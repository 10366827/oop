using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    //  Represents what a typical Library should be able to do for a Patron
    public interface ILibrary
    {
        //  have a loan duration
        double LoanDuration { get; }
        //  allow a search of the inventory
        List<Book> SearchInventory(string search);
        //  see list of books available
        List<Book> ViewAvailableBooks();
        //  query if they have a book
        bool HaveBook(Book b);
        //  query if they have a book, through isbn
        bool HaveBook(string isbn);
        //  check if a book is available ( not all on loan )
        bool IsBookAvailable(Book b);
        //  Register a book loan
        bool LoanBook(Book book, LibraryPatron patron);
        //  Borrower can return a book
        bool BookReturn(Book book, LibraryPatron patron);
    }
}
