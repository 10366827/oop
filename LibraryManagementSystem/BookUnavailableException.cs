using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class BookUnavailableException : Exception
    {
        public BookUnavailableException():base("Book Unavailable")
        {
        }

        public BookUnavailableException(string message) : base(message)
        {
        }

        public BookUnavailableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BookUnavailableException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
