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
    public partial class AddLecturerForm : Form
    {
        private INotifyPersonAdded listener;

        public AddLecturerForm(INotifyPersonAdded parent)
        {
            InitializeComponent();
            listener = parent;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //  Validation
            if (AnyFieldsEmpty())
            {
                new NotificationForm("All fields must be filled.").ShowDialog();
                return;
            }
            if (!ValidatorHelper.IsEmailValid(inEmail.Text))
            {
                new NotificationForm("Invalid Email.").ShowDialog();
                return;
            }
            if (!ValidatorHelper.IsValidPPSN(inPPSN.Text))
            {
                new NotificationForm("Invalid PPSN. Must be 7 numbers, followed by a letter, and finally a letter or a space e.g. 1234567AW").ShowDialog();
                return;
            }

            decimal tmpSal;
            if (!decimal.TryParse(inSalary.Text, out tmpSal))
            {
                new NotificationForm("Salary must be a decimal value.").ShowDialog();
                return;
            }
            Lecturer tmp = new Lecturer(inID.Text, tmpSal, inPPSN.Text, inName.Text, inAddress.Text, inPhone.Text, inEmail.Text);
            if (College.Instance.Contains(tmp))
            {
                new NotificationForm("This person already exists in the system (PPSN).").ShowDialog();
                return;
            }

            College.Instance.Add(tmp);
            listener.NotifyPersonAdded();
            this.Close();
        }

        private bool AnyFieldsEmpty()
        {
            return string.IsNullOrWhiteSpace(inID.Text) ||
                string.IsNullOrWhiteSpace(inSalary.Text) ||
                string.IsNullOrWhiteSpace(inPPSN.Text) ||
                string.IsNullOrWhiteSpace(inName.Text) ||
                string.IsNullOrWhiteSpace(inAddress.Text) ||
                string.IsNullOrWhiteSpace(inEmail.Text) ||
                string.IsNullOrWhiteSpace(inPhone.Text);
        }
    }
}
