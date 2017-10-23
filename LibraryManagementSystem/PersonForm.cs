using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    //  Displays a Person's details and allows user to return their books individually
    public partial class PersonForm : Form
    {
        private LibraryPatron patron;

        public PersonForm(LibraryPatron p)
        {
            InitializeComponent();
            patron = p;
            if(patron == null)
            {
                new NotificationForm("Failed to load person.").ShowDialog();
                //  log
                this.Close();
            }
            bool isStudent = patron is Student;
            if (isStudent)
            {
                Student tmp = patron as Student;
                outputRole.Text = tmp.Status.ToString();
            }
            else
            {
                Lecturer tmp = patron as Lecturer;
                outputRole.Text = "Lecturer";
                outputID.Text = tmp.ID;
            }
            outputName.Text = patron.Name;
            outputAddress.Text = patron.Address;
            outputEmail.Text = patron.Email;
            outputPhone.Text = patron.Phone;
            outputPPSN.Text = patron.PPSN;
            booksBorrowedList.DataSource = patron.ToList();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            Book bookToReturn = booksBorrowedList.SelectedItem as Book;
            if (bookToReturn != null) {
                var confirmResult = MessageBox.Show(
                    string.Format("Are you sure you want to return book: {0} by {1}", bookToReturn.Title, bookToReturn.Author),
                                         "Confirmation",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes && patron.ReturnBook(bookToReturn))
                {
                    //  Refresh the list ( = null is the cleanest way to force a refresh )
                    booksBorrowedList.DataSource = null;
                    booksBorrowedList.DataSource = patron.ToList();
                }
            }
        }
    }
}
