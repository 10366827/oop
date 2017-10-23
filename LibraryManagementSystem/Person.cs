using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class Person:IComparable<Person>, IEquatable<Person>
    {
        //  Private variables
        protected string ppsn, name, address, phone, email;

        //  Accessors and Mutators
        public string PPSN { get => ppsn; private set => ppsn = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        //  constructor(s)
        protected Person(string ppsn, string name, string address, string phone, string email)
        {
            PPSN = ppsn;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }

        //  IComparable<Person>
        public int CompareTo(Person other)
        {
            return ppsn.CompareTo(other.ppsn);
        }

        //  IEquatable<Person>
        public bool Equals(Person other)
        {
            return ppsn == other.ppsn;
        }

        public override string ToString()
        {
            return string.Format("{0, -22}",name);
        }
        
        public override int GetHashCode()
        {
            return ppsn.GetHashCode();
        }
    }
}
