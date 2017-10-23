using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class LibraryPatron : Person, ICollection<LoanedBook>
    {
        //  Private Variables
        private List<LoanedBook> borrowedBooks;

        //  Constructor(s)
        public LibraryPatron(string ppsn, string name, string address, string phone, string email) : base(ppsn, name, address, phone, email)
        {
            borrowedBooks = new List<LoanedBook>();
        }

        //public List<BorrowedBook> BorrowedBooks { get => borrowedBooks; private set => borrowedBooks = value; }

        public int Count => ((ICollection<LoanedBook>)borrowedBooks).Count;

        public bool IsReadOnly => ((ICollection<LoanedBook>)borrowedBooks).IsReadOnly;

        //  A student can borrow a book, up to their limited amount, as long as they have none overdue
        public abstract bool ReachedBookLimit();

        //  Checks if patron has a book
        public bool HasBook(Book b)
        {
            return borrowedBooks.Contains(b);
        }

        //  Attempt to borrow a book from a library
        public bool RequestLoan(Book book, ILibrary library)
        {
            return library.LoanBook(book, this);
        }

        //  returns a book to the library if they have it
        public bool ReturnBook(Book b)
        {
            if (borrowedBooks.Exists(x => x.ISBN == b.ISBN))
            {
                int index = borrowedBooks.FindIndex(x => x.ISBN == b.ISBN);
                if (index >= 0 && borrowedBooks[index].ReturnBook(this))
                    return borrowedBooks.Remove(borrowedBooks[index]);
            }
            return false;
        }

        //  Should notify when books become overdue
        public void EmailLateNoticeAlert(Book b)
        {
            throw new NotImplementedException();
        }

        //  View details of a particular borrowed book
        public LoanedBook ViewBorrowedBookDetails(Book b)
        {
            try
            {
                if (!borrowedBooks.Contains(b))
                    throw new BookNotFoundException(string.Format("BorrowedBook: {0} not found.", b.ISBN));
                else if (b == null)
                    throw new ArgumentNullException("Argument null in Student.ViewBorrowedBook(Book)");
            }
            catch (BookNotFoundException bnfe)
            {
                Console.WriteLine(bnfe.Message);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            return borrowedBooks[borrowedBooks.IndexOf(b as LoanedBook)];
        }

        //  check if a particular book is overdue
        public bool IsBookOverdue(Book b)
        {
            if (borrowedBooks.Contains(b))
                return borrowedBooks.Find(x => x.Equals(b)).IsOverdue();
            return false;
        }

        //  see if patron has any overdue books
        public bool HasOverdueBook()
        {
            return borrowedBooks.Exists(x => x.IsOverdue());
        }

        //  overridden object methods 
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Add(LoanedBook item)
        {
            if(!ReachedBookLimit() && !Contains(item))
                ((ICollection<LoanedBook>)borrowedBooks).Add(item);
        }

        public void Clear()
        {
            ((ICollection<LoanedBook>)borrowedBooks).Clear();
        }

        public bool Contains(LoanedBook item)
        {
            return ((ICollection<LoanedBook>)borrowedBooks).Contains(item);
        }

        public void CopyTo(LoanedBook[] array, int arrayIndex)
        {
            ((ICollection<LoanedBook>)borrowedBooks).CopyTo(array, arrayIndex);
        }

        public bool Remove(LoanedBook item)
        {
            return ((ICollection<LoanedBook>)borrowedBooks).Remove(item);
        }

        public IEnumerator<LoanedBook> GetEnumerator()
        {
            return ((ICollection<LoanedBook>)borrowedBooks).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<LoanedBook>)borrowedBooks).GetEnumerator();
        }
    }
}
