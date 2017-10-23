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
    public partial class AddBookForm : Form
    {
        private INotifyBookAdded listener;

        public AddBookForm(INotifyBookAdded _listener)
        {
            InitializeComponent();
            listener = _listener;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (AnyFieldsEmpty())
            {
                new NotificationForm("All fields must be filled.").ShowDialog();
                return;
            }
            else if (!ValidatorHelper.MeetsSlimlinedISBNRequirements(inISBN.Text))
            {
                new NotificationForm("Invalid ISBN. Must be at least 10 digits long, and contain only numbers, hyphons, or spaces").ShowDialog();
                return;
            }

            Book b = new Book(inISBN.Text, inTitle.Text, inAuthor.Text, inPublisher.Text, inCategory.Text, (int)inQuantity.Value);
            College.Instance.Library.AddBook(b);
            listener.NotifyBookAdded();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool AnyFieldsEmpty()
        {
            return string.IsNullOrWhiteSpace(inISBN.Text) || 
                string.IsNullOrWhiteSpace(inTitle.Text) || 
                string.IsNullOrWhiteSpace(inAuthor.Text) || 
                string.IsNullOrWhiteSpace(inPublisher.Text) || 
                string.IsNullOrWhiteSpace(inCategory.Text) || 
                string.IsNullOrWhiteSpace(inQuantity.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
