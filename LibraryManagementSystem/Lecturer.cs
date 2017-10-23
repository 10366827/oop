using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    //  A lecturer object, that inherits LibraryPatron, and in turn Person
    public class Lecturer:LibraryPatron
    {
        //  Private variables
        private string id;
        private decimal salary;

        //  Accessors and Mutators
        public string ID { get => id; private set => id = value; }
        public decimal Salary { get => salary; private set => salary = value; }
        
        //  Constructor(s)
        public Lecturer(string id, decimal salary, string ppsn, string name, string address, string phone, string email) : base(ppsn, name, address, phone, email)
        {
            ID = id;
            Salary = salary;
        }

        public override bool ReachedBookLimit()
        {
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //  override(s)
        public override string ToString()
        {
            return base.ToString() + "[" + id + "]";
        }
    }
}
