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
    //  Simple popup notification window
    public partial class NotificationForm : Form
    {
        public NotificationForm(string message)
        {
            InitializeComponent();
            outputNotification.Text = message;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
