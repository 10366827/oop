using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagementSystem;

namespace LibraryManagementSystem_Tests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void RequestLoanTest()
        {
            Library library = new Library();
            Book testBook = new Book("testisbn", "testtitle", "testauthor", "testpublisher", "testcategory", 5);
            LibraryPatron patron = new Student("testid", GradStatus.Postgrad, "testppsn","testname","testaddress","99999999", "test@email.com");
            
            //  Book not added yet, should return false
            Assert.IsFalse(patron.RequestLoan(testBook, library));

            //  Person not added to the College system, therefore the library will not allow it
            library.AddBook(testBook);
            Assert.IsFalse(patron.RequestLoan(testBook, library));

            //  Person now added to the College's system, therefore should be elegible for a book loan
            College.Instance.Add(patron);
            Assert.IsTrue(patron.RequestLoan(testBook, library));
            
            //  Should not loan the book, and return false, since the student already has the book ( 1 per person )
            Assert.IsFalse(patron.RequestLoan(testBook, library));

            College.Instance.Remove(patron);
        }

        [TestMethod]
        public void ReturnBookTest()
        {
            Library library = new Library();
            Book testBook = new Book("testisbn", "testtitle", "testauthor", "testpublisher", "testcategory", 5);
            LibraryPatron patron = new Student("testid", GradStatus.Postgrad, "testppsn", "testname", "testaddress", "99999999", "test@email.com");
            library.AddBook(testBook);
            College.Instance.Add(patron);

            //  Patron should have no books, so should fail
            Assert.IsFalse(patron.ReturnBook(testBook));
            
            //  The patron is now given the book, and should successfully return it
            library.LoanBook(testBook, patron);
            Assert.IsTrue(patron.HasBook(testBook));
            Assert.IsTrue(library.PeopleWith(testBook).Count == 1);
            Assert.IsTrue(patron.ReturnBook(testBook));
            Assert.IsFalse(patron.HasBook(testBook));
            Assert.IsTrue(library.PeopleWith(testBook).Count == 0);

            //  Now that the book was returned, this should failed as he should no longer have the book
            Assert.IsFalse(patron.ReturnBook(testBook));

            College.Instance.Remove(patron);
        }

        [TestMethod]
        public void ReachedBookLimitTest()
        {
            Library library = new Library();
            //  Lecturer is not being tested, as it has no BookLimit, and simply always return false for ReachedBookLimit()
            Student undergrad = new Student("testid", GradStatus.Undergrad, "testppsn", "testname", "testaddress", "99999999", "test@email.com");
            Student postgrad = new Student("testid", GradStatus.Postgrad, "testppsn", "testname", "testaddress", "99999999", "test@email.com");
            College.Instance.Add(undergrad);
            College.Instance.Add(postgrad);
            int i;
            for (i = 0; i < 20; i++)
                library.AddBook(new Book("testisbn"+i, "testtitle", "testauthor", "testpublisher", "testcategory", 5));

            //  undergrad hasn't been assigned any books yet, so shouldn't be at his limit
            Assert.IsFalse(undergrad.ReachedBookLimit());
            for(i = 0; i < (int)undergrad.Status; i++)
            {
                //  Giving undergrad their maximum amount of books, should all be true
                Assert.IsTrue(library.LoanBook(library.GetBook("testisbn" + i), undergrad));
            }
            //  Now that undergrad is at their cap, ReachedBookLimit() should return true, and a loan should not be allowed
            Assert.IsTrue(undergrad.ReachedBookLimit());
            Assert.IsFalse(library.LoanBook(library.GetBook("testisbn" + i), undergrad));


            //  postgrad hasn't been assigned any books yet, so shouldn't be at their limit
            Assert.IsFalse(postgrad.ReachedBookLimit());
            for (i = 0; i < (int)postgrad.Status; i++)
            {
                //  Giving postgrad their maximum amount of books, should all be true
                Assert.IsTrue(library.LoanBook(library.GetBook("testisbn" + i), postgrad));
            }
            //  Now that postgrad is at their cap, ReachedBookLimit() should return true, and a loan should not be allowed
            Assert.IsTrue(postgrad.ReachedBookLimit());
            Assert.IsFalse(library.LoanBook(library.GetBook("testisbn" + i), postgrad));

            College.Instance.Remove(postgrad);
            College.Instance.Remove(undergrad);
        }

        [TestMethod]
        public void PeopleWithTest()
        {
            Library library = new Library();
            LibraryPatron patron1 = new Student("testid", GradStatus.Undergrad, "testppsn", "testname", "testaddress", "99999999", "test@email.com");
            LibraryPatron patron2 = new Lecturer("lecturertestid", 10000m, "lecturertestppsn", "lecname", "lecaddress", "244242", "lec@email.com");
            College.Instance.Add(patron1);
            College.Instance.Add(patron2);
            Book testBook = new Book("testisbn", "testtitle", "testauthor", "testpublisher", "testcategory", 5);
            library.AddBook(testBook);

            //  Noone should have testBook yet, so should return 0
            Assert.IsTrue(library.PeopleWith(testBook).Count == 0);

            library.LoanBook(testBook, patron1);
            //  List size should be 1
            Assert.IsTrue(library.PeopleWith(testBook).Count == 1);
            //  Only person in the list should be patron1
            Assert.IsTrue(library.PeopleWith(testBook).Exists(x => x.Equals(patron1)));
            //  Patron2 should not be in the list
            Assert.IsFalse(library.PeopleWith(testBook).Exists(x => x.Equals(patron2)));

            //  Loan the book to patron 2
            patron2.RequestLoan(testBook, library);
            //  List returned should be size 2 now
            Assert.IsTrue(library.PeopleWith(testBook).Count == 2);
            //  The list should now contain patron2
            Assert.IsTrue(library.PeopleWith(testBook).Contains(patron2));

            patron1.ReturnBook(testBook);
            patron2.ReturnBook(testBook);
            //  Since both patrons have now returned their books, there should be no people with the book in the system
            Assert.IsTrue(library.PeopleWith(testBook).Count == 0);

            College.Instance.Remove(patron1);
            College.Instance.Remove(patron2);
        }

        [TestMethod]
        public void IsBookAvailableTest()
        {
            Library library = new Library();
            Student patron = new Student("testid", GradStatus.Undergrad, "testppsn", "testname", "testaddress", "99999999", "test@email.com");
            College.Instance.Add(patron);
            //  add 1 testBook to the library inventory
            int quantity = 1;
            Book testBook = new Book("testisbn", "testtitle", "testauthor", "testpublisher", "testcategory", quantity);

            //  Book isn't in the library inventory, therefore should be unavailable
            Assert.IsFalse(library.IsBookAvailable(testBook));

            //  Book is in the library inventory, and is not on loan, should be available
            library.AddBook(testBook);
            Assert.IsTrue(library.IsBookAvailable(testBook));

            //  Book loaned to a patron, therefore should no longer be available
            library.LoanBook(testBook, patron);
            Assert.IsFalse(library.IsBookAvailable(testBook));

            //  Book returned by borrower, therefore should be available once again
            patron.ReturnBook(testBook);
            Assert.IsTrue(library.IsBookAvailable(testBook));

            College.Instance.Remove(patron);
        }
    }
}
