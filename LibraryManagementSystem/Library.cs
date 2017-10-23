using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    //  Represents a Library
    public class Library:ILibrary
    {
            //  Private variables

        //  inventory holds the library inventory, and who's borrowing
        private SortedList<Book, List<LibraryPatron>> inventory;

        //  Accessors and Mutators
        internal SortedList<Book, List<LibraryPatron>> Inventory { get => inventory; }

        //  Library loan duration
        public double LoanDuration => 7;

        //  Constructor(s)
        public Library()
        {
            inventory = new SortedList<Book, List<LibraryPatron>>();
        }

        public Library(List<Book> books)
        {
            inventory = new SortedList<Book, List<LibraryPatron>>();
            foreach (Book book in books)
                inventory.Add(book, new List<LibraryPatron>());
        }

        //  Methods

        public bool HaveBook(Book b)
        {
            return inventory.ContainsKey(b);
        }

        public bool HaveBook(string isbn)
        {
            return inventory.Keys.ToList().Exists(x => x.ISBN == isbn);
        }

        public bool LoanBook(Book book, LibraryPatron patron)
        {
            if (!College.Instance.Contains(patron))
                return false;
            if(!patron.ReachedBookLimit() && !patron.Contains(book) && IsBookAvailable(book))
            {
                LoanedBook loanBook = new LoanedBook(book, this);
                patron.Add(loanBook);
                inventory[book].Add(patron);
                return true;
            }
            return false;
        }

        //public bool RegisterBookLoan(Book book, LibraryPatron borrower)
        //{
        //    if (College.Instance.PersonInSystem(borrower as Person))
        //        if (borrower.CanBorrow() && !borrower.HasBook(book) && IsBookAvailable(book))
        //        {
        //            inventory[book].Add(borrower);
        //            return true;
        //        }
        //    return false;
        //}

        public bool BookReturn(Book book, LibraryPatron patron)
        {
            if (inventory.ContainsKey(book) && inventory[book].Contains(patron))
                return inventory[book].Remove(patron);
            return false;
        }

        public bool IsBookAvailable(Book b)
        {
            return inventory.Keys.Contains(b) && inventory[b].Count < b.TotalQuantity;
        }

        public List<Book> ViewAvailableBooks()
        {
            return inventory.Keys.Where(x => inventory[x].Count < x.TotalQuantity).ToList();
        }
        
        //  Returns a list of books that include a string in some form
        public List<Book> SearchInventory(string search)
        {
            return new List<Book>(inventory.Keys.Where(x => x.Concat().Contains(search)));
        }

        //  Add a book to the library inventory
        public void AddBook(Book b)
        {
            if (!inventory.ContainsKey(b))
                inventory.Add(b, new List<LibraryPatron>());
            else
                inventory.Keys[inventory.IndexOfKey(b)].AddQuantity(b.TotalQuantity);
        }

        //  Number available for a particular book
        public int NumberAvailable(Book b)
        {
            if (!inventory.Keys.Contains(b))
                return 0;
            return b.TotalQuantity - inventory[b].Count;
        }

        //  People who are currently borrowing a book
        public List<LibraryPatron> PeopleWith(Book b)
        {
            if(inventory.ContainsKey(b))
                return inventory[b];
            return new List<LibraryPatron>(0);
        }

        //  Get a list of patrons that have overdue book(s)
        public List<LibraryPatron> OverduePatrons()
        {
            HashSet<LibraryPatron> overdueBorrowers = new HashSet<LibraryPatron>();
            List<Book> borrowedBooks = inventory.Keys.Where(x => inventory[x].Count > 0).ToList<Book>();
            foreach (Book book in borrowedBooks)
                foreach(LibraryPatron patron in inventory[book].FindAll(x => x.HasOverdueBook()))
                    overdueBorrowers.Add(patron);
            return overdueBorrowers.ToList<LibraryPatron>();
        }

        //  Find all the patrons that have a particular book overdue
        public List<LibraryPatron> Overdue(Book b)
        {
            return inventory[b].FindAll(x => x.IsBookOverdue(b));
        }

        //  Get a book from the inventory corresponding to an isbn
        public Book GetBook(string isbn)
        {
            return inventory.Keys.ToList<Book>().Find(x => x.ISBN == isbn);
        }
    }
}
