using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    //  View a book's details, and allow loaning or returning of the book
    public partial class BookForm : Form, INotifyLoan, INotifyReturn
    {
        private Book book;

        public BookForm(Book b)
        {
            InitializeComponent();
            book = b;
            outputAuthor.Text = book.Author;
            outputCategory.Text = book.Category;
            outputISBN.Text = book.ISBN;
            outputPublisher.Text = book.Publisher;
            outputQuantity.Text = ""+ book.TotalQuantity;
            outputTitle.Text = book.Title;
            int numAvailable = UpdateNumAvailable();
            if (numAvailable == 0)
                loanButton.Enabled = false;
            else if (numAvailable == book.TotalQuantity)
                returnButton.Enabled = false;
        }

        //  When a loan is made, update the ui
        public void NotifyLoan()
        {
            int numAvailable = UpdateNumAvailable();
            if (numAvailable == 0)
                loanButton.Enabled = false;
            else
                returnButton.Enabled = true;
        }

        //  When a return is made, update the ui
        public void NotifyReturn()
        {
            int numAvailable = UpdateNumAvailable();
            if (numAvailable == book.TotalQuantity)
                returnButton.Enabled = false;
            else
                loanButton.Enabled = true;
        }

        //  Refreshes the value of the outputAvailable field (after a loan or return)
        private int UpdateNumAvailable()
        {
            int numAvailable = College.Instance.Library.NumberAvailable(book);
            outputAvailable.Text = "" + numAvailable;
            return numAvailable;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  Open a loan form for the book
        private void loanButton_Click(object sender, EventArgs e)
        {
            new LoanForm(book, this).ShowDialog();
        }

        //  Open a return form for the book
        private void returnButton_Click(object sender, EventArgs e)
        {
            new ReturnForm(book, this).ShowDialog();
        }
    }
}
