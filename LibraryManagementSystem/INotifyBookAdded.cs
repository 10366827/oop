using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    //  notify listener that a book has been added to the system
    public interface INotifyBookAdded
    {
        void NotifyBookAdded();
    }
}
