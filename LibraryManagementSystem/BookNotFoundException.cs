using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException():base("Book Not Found")
        {
        }

        public BookNotFoundException(string message) : base(message)
        {
        }

        public BookNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BookNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
