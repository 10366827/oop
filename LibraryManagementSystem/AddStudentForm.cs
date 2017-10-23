using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace LibraryManagementSystem
{
    public partial class AddStudentForm : Form
    {
        private INotifyPersonAdded listener;

        public AddStudentForm(INotifyPersonAdded parent)
        {
            InitializeComponent();
            inGradStatus.SelectedIndex = 0;
            listener = parent;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            Student tmp = new Student(inID.Text, (inGradStatus.SelectedIndex == 0 ? GradStatus.Undergrad : GradStatus.Postgrad), inPPSN.Text, inName.Text, inAddress.Text, inPhone.Text, inEmail.Text);
            if (College.Instance.Contains(tmp))
            {
                new NotificationForm("This person already exists in the system (PPSN).").ShowDialog();
                return;
            }
            College.Instance.Add(tmp);
            listener.NotifyPersonAdded();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool AnyFieldsEmpty()
        {
            return string.IsNullOrWhiteSpace(inGradStatus.Text) ||
                string.IsNullOrWhiteSpace(inName.Text) ||
                string.IsNullOrWhiteSpace(inEmail.Text) ||
                string.IsNullOrWhiteSpace(inID.Text) ||
                string.IsNullOrWhiteSpace(inAddress.Text) ||
                string.IsNullOrWhiteSpace(inPhone.Text) ||
                string.IsNullOrWhiteSpace(inPPSN.Text);
        }
    }
}
