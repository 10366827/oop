using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    //  notify listener that the list of overdue books has been updated
    public interface INotifyOverdueUpdate
    {
        void NotifyOverdueUpdate();
    }
}
