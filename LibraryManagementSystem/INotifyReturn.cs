using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    //  notify listener that an object has been returned
    public interface INotifyReturn
    {
        void NotifyReturn();
    }
}
