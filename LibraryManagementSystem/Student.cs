using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    //  enum used to represent a students status, and doubles has their book loan limit
    public enum GradStatus { Undergrad = 5, Postgrad = 10 }

    //  Student that inherits LibraryPatron, and in turn Person
    public class Student : LibraryPatron
    {
        //  Private fields
        private string id;
        private GradStatus status;

        //  Accessors and Mutators
        public string ID { get => id; private set => id = value; }
        public GradStatus Status { get => status; set => status = value; }

        //  constructor(s)
        public Student(string id, GradStatus status, string ppsn, string name, string address, string phone, string email) : base(ppsn, name, address, phone, email)
        {
            ID = id;
            Status = status;
        }

        //  abstract implementations

        //  A student can borrow a book, up to their limited amount, as long as they have none overdue
        public override bool ReachedBookLimit()
        {
            return (Count >= (int)status);
        }

        //  overridden object methods 
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString() + "[" + id + "]";
        }
    }
}
