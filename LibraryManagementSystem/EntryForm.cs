using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    //  The home page of the application
    public partial class EntryForm : Form, INotifyOverdueUpdate, INotifyPersonAdded, INotifyBookAdded
    {
        //  My timer thread for keeping the "Overdue Patrons" box updated
        private static System.Threading.Timer updater;

        public EntryForm()
        {
            InitializeComponent();
            //  Point person ListBox datasource at the College's list of people
            personSearchBox.DataSource = College.Instance.ToList();
            //  Point books ListBox datasource at the Library's list of books
            bookSearchBox.DataSource = College.Instance.Library.Inventory.Keys.ToList<Book>();
            patronsOverdueBox.DataSource = new List<LibraryPatron>();

            //  Run thread every 1 second
            updater = new System.Threading.Timer(UpdateCallback, this, 1000, 1000);
        }
        
        //  Called by my Timer every 1 second to update the "Overdue Patrons" box
        private static void UpdateCallback(object obj)
        {
            //  Notify my listener, the home page (EntryForm) that it's due an update
            if (obj is EntryForm)
                (obj as EntryForm).NotifyOverdueUpdate();
        }

        private void addLecturerClicked(object sender, EventArgs e)
        {
            new AddLecturerForm(this).ShowDialog();
        }

        private void personSearchBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LibraryPatron p = personSearchBox.SelectedItem as LibraryPatron;
            if (p != null)
                new PersonForm(p).ShowDialog();
        }

        private void inputPersonSearch_TextChanged(object sender, EventArgs e)
        {
            if (inputPersonSearch.Text.Length == 0)
                personSearchBox.DataSource = College.Instance.ToList();
            else
                personSearchBox.DataSource = College.Instance.GetPeople(inputPersonSearch.Text.ToLower());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddStudentForm(this).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AddBookForm(this).ShowDialog();
        }

        private void inputSearchBook_TextChanged(object sender, EventArgs e)
        {
            if (inputSearchBook.Text.Length == 0)
                bookSearchBox.DataSource = College.Instance.Library.Inventory.Keys.ToList<Book>();
            else {
                string searchText = inputSearchBook.Text.ToLower();
                bookSearchBox.DataSource = College.Instance.Library.Inventory.Keys.ToList<Book>().FindAll(
                    x => x.Title.ToLower().Contains(searchText) || x.Author.ToLower().Contains(searchText));
            }
        }

        private void bookSearchBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Book b = bookSearchBox.SelectedItem as Book;
            if (b != null)
                new BookForm(b).ShowDialog();
        }

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            updater.Dispose();
        }

        //  Person selected with button, open PersonForm for the selected Person
        private void personDetailsButton_Click(object sender, EventArgs e)
        {
            LibraryPatron p = personSearchBox.SelectedItem as LibraryPatron;
            if (p != null)
                new PersonForm(p).ShowDialog();
        }

        //  Book selected with button, open a BookForm for the selected Book
        private void bookDetailsButton_Click(object sender, EventArgs e)
        {
            Book b = bookSearchBox.SelectedItem as Book;
            if (b != null)
                new BookForm(b).ShowDialog();
        }

        //  Lecturer radiobutton selected, update the list
        private void lecturerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePersonList();
        }

        //  All radiobutton selected, update the list
        private void allRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePersonList();
        }

        //  Student radiobutton selected, update the list
        private void studentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePersonList();
        }

        //  Update the person list, and make sure to account for the search textbox, as well as radiobutton choice
        private void UpdatePersonList()
        {
            personSearchBox.DataSource = null;
            if (allRadioButton.Checked)
            {
                if (inputPersonSearch.Text.Length == 0)
                    personSearchBox.DataSource = College.Instance.ToList();
                else
                    personSearchBox.DataSource = College.Instance.GetPeople(inputPersonSearch.Text.ToLower());
            }
            else if (studentsRadioButton.Checked)
            {
                if (inputPersonSearch.Text.Length == 0)
                    personSearchBox.DataSource = College.Instance.GetStudents();
                else
                    personSearchBox.DataSource = College.Instance.GetStudents(inputPersonSearch.Text.ToLower());
            }
            else
            {
                if (inputPersonSearch.Text.Length == 0)
                    personSearchBox.DataSource = College.Instance.GetLecturers();
                else
                    personSearchBox.DataSource = College.Instance.GetLecturers(inputPersonSearch.Text.ToLower());
            }
        }

        //  Update the booklist, and make sure to account for the search textbox
        private void UpdateBooksData()
        {
            if (inputSearchBook.Text.Length == 0)
            {
                bookSearchBox.DataSource = College.Instance.Library.Inventory.Keys.ToList<Book>();
            }
            else
            {
                string searchText = inputSearchBook.Text.ToLower();
                bookSearchBox.DataSource = College.Instance.Library.Inventory.Keys.ToList<Book>().FindAll(
                    x => x.Title.ToLower().Contains(searchText) || x.Author.ToLower().Contains(searchText));
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //  When user double clicks on a person in the Overdue box, open that person's form
        private void patronsOverdueBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LibraryPatron p = patronsOverdueBox.SelectedItem as LibraryPatron;
            if (p != null)
                new PersonForm(p).ShowDialog();
        }

        //  Notifications

        //  Update the "Overdue Patrons" box
        public void NotifyOverdueUpdate()
        {
            List<LibraryPatron> patrons = College.Instance.Library.OverduePatrons();
            if (!Enumerable.SequenceEqual(patrons, patronsOverdueBox.DataSource as List<LibraryPatron>))
                patronsOverdueBox.DataSource = patrons;
        }

        //  A person should have been added to the system, update person listbox
        public void NotifyPersonAdded()
        {
            UpdatePersonList();
        }

        //  A book should have been added to the system, update book listbox
        public void NotifyBookAdded()
        {
            UpdateBooksData();
        }
    }
}
