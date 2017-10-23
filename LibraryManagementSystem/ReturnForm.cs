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
    public partial class ReturnForm : Form
    {
        private Book book;
        private INotifyReturn listener;

        public ReturnForm(Book b, INotifyReturn parent)
        {
            InitializeComponent();
            book = b;
            if (book != null)
                borrowedBox.DataSource = College.Instance.Library.PeopleWith(book);
            else
                borrowedBox.DataSource = new List<LibraryPatron>();

            listener = parent;
        }

        private void borrowersBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LibraryPatron borrower = borrowedBox.SelectedItem as LibraryPatron;
            if (borrower != null)
            {
                var confirmResult = MessageBox.Show(
                     string.Format("Are you sure you want to return '{0}', by {1}, from {2}", book.Title, book.Author, borrower.Name),
                                    "Confirmation", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes && borrower.ReturnBook(book))
                {
                    listener.NotifyReturn();
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
