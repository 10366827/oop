using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    //  Represents a book that has been borrowed
    public class LoanedBook : Book, IComparable<Book>, IEquatable<Book>
    {
            //  Private Variables 

        //  the date it was issued
        private DateTime dateIssued;
        //  the date the book is due for return
        private DateTime dueDate;
        //  the library it was borrowed from
        private ILibrary library;
        //  whether or not the book loan has already been extended ( only once )
        private bool extended;

            //  Accessors and Mutators
        public DateTime IssueDate { get => dateIssued; private set => dateIssued = value; }
        public DateTime DueDate { get => dueDate; private set => dueDate = value; }
        internal ILibrary Library { get => library; private set => library = value; }
        public DateTime DateIssued { get => dateIssued; private set => dateIssued = value; }

        //  Constructor(s)
        public LoanedBook(Book book, ILibrary library) : base(book.ISBN, book.Title, book.Author, book.Publisher, book.Category, book.TotalQuantity)
        {
            //  set the date issued to right now
            DateIssued = DateTime.Now;

            //  If the application is compiled with the DebugMode variable set
            if (College.DebugMode)
            {
                //  DueDate becomes a random time between the present and Min / Max seconds away
                Random r = new Random();
                DueDate = DateTime.Now.AddMilliseconds(
                    r.Next((int)College.DebugTimeBetweenMillis.Min, (int)College.DebugTimeBetweenMillis.Max));
            }
            else
                DueDate = DateTime.Now.AddDays(library.LoanDuration);   //  library decides loan duration

            Library = library;
            extended = false;
        }

        //  Request a loan extension
        public bool RequestExtension()
        {
            //  only allowed once
            if (!extended)
            {
                if (College.DebugMode)
                {
                    Random r = new Random();
                    DueDate = DateTime.Now.AddMilliseconds(
                        r.Next((int)College.DebugTimeBetweenMillis.Min, (int)College.DebugTimeBetweenMillis.Max));
                }
                else
                    dueDate.AddDays(library.LoanDuration);
                extended = true;
                return true;
            }
            return false;
        }

        //  return a borrowed book
        public bool ReturnBook(LibraryPatron borrower)
        {
            return library.BookReturn(this, borrower);
        }

        //  check if the book is overdue
        public bool IsOverdue()
        {
            return DateTime.Now.CompareTo(DueDate) > 0;
        }

        //  present the issued date&time as a string
        public string ShowIssuedDateTime()
        {
            return DateIssued.ToString();
        }

        //  present the due date&time as a string
        public string ShowDueDateTime()
        {
            return DueDate.ToString();
        }

        //  overriden object methods

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("'{0, -21}{1}", string.Concat(Title, "'"), 
                (IsOverdue() ?  "OVERDUE: "+ShowDueDateTime() :  "Due: " + ShowDueDateTime()));
        }
    }
}
