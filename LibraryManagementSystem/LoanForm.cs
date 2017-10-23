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
    public partial class LoanForm : Form
    {
        LibraryPatron borrower;
        Book book;
        INotifyLoan listener;
        
        public LoanForm(Book b, INotifyLoan parent)
        {
            InitializeComponent();
            personSearchBox.DataSource = College.Instance.ToList();
            book = b;
            listener = parent;
        }

        //  Whenever the text in the search box changes, this method gets called
        private void inputPersonSearch_TextChanged(object sender, EventArgs e)
        {
            if (inputPersonSearch.Text.Length == 0)
                personSearchBox.DataSource = College.Instance.ToList();
            else
                personSearchBox.DataSource = College.Instance.GetPeople(inputPersonSearch.Text.ToLower());
        }

        //  when user double clicks on a person this is called
        private void personSearchBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //  Safety measure
            try
            {
                borrower = personSearchBox.SelectedItem as LibraryPatron;
                if (borrower == null)
                    throw new ArgumentNullException("LoanForm[39]: Selected person not of type 'LibraryPatron'");
            }catch(ArgumentNullException ane)
            {
                //  log exception
                new NotificationForm("Patron not found.").ShowDialog();
            }

            //  If borrower has reached their book limit, notify and do not allow loan
            if (borrower.ReachedBookLimit())
                new NotificationForm(borrower.Name + " has met their quota of " + (int)(borrower as Student).Status + " books, and therefore cannot borrow anymore books.").ShowDialog();
            else if (borrower.HasBook(book))    //  if they already have the book, not allowed another
                new NotificationForm(borrower.Name + " already has a copy of this book. 1 copy permitted only.").ShowDialog();
            else
            {
                //  Confirm loaning book to the right person
                var confirmResult = MessageBox.Show(
                string.Format("Are you sure you want to loan: '{0}', by {1}, to {2}", book.Title, book.Author, borrower.Name),
                                    "Confirmation",
                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    //  User confirmed yes, therefore system attempt to loan selected patron the book
                    if (College.Instance.Library.LoanBook(book, borrower))
                        listener.NotifyLoan();  //  update listener 

                    this.Close();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
