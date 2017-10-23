using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    //  Main entry point to the program
    //  Singleton pattern, as there should only be 1 College instantiated
    public class College: ICollection<Person>
    {
        //  Testing variables; set to false and rebuild to load no test data and use a library maintained loan period
        public const bool DebugMode = true;
        public enum DebugTimeBetweenMillis { Min=10000, Max=25000 }
        
        //  Launches "EntryForm", the starting point of the gui/program
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EntryForm());
        }
        
        //  Private Fields
        private static College instance;
        private List<Person> people;
        private Library library;
        
        //internal List<Person> People { get => people; }
        public Library Library { get => library; }

        private College()
        {
            if (DebugMode)
            {
                people = JsonHelper.GetPeople();
                library = new Library(JsonHelper.GetInventory());
            }
            else
            {
                people = new List<Person>();
                library = new Library();
            }
        }

        //  public singelton instance accessor
        public static College Instance
        {
            get
            {
                if (instance == null)
                    instance = new College();
                return instance;
            }
        }

        public int Count => ((ICollection<Person>)people).Count;

        public bool IsReadOnly => ((ICollection<Person>)people).IsReadOnly;

        //  add a new Person to the list of people in the system
        public bool AddPerson(Person p)
        {
            if (!Contains(p))
            {
                Add(p);
                return true;
            }
            return false;
        }

        //  try remove a person from the system
        public bool RemovePerson(Person p)
        {
            return people.Remove(p);
        }

        //  check if a person is in the system by ppsn
        public bool PersonInSystem(string ppsn)
        {
            return people.Exists(x => x.PPSN == ppsn);
        }

        //  check if a person is in the system
        public bool PersonInSystem(Person p)
        {
            if(p != null)
                return people.Contains(p);
            return false;
        }

        public List<Person> GetPeople(string search)
        {
            return people.FindAll(x => x.Name.ToLower().Contains(search.ToLower()));
        }

        public List<Person> GetStudents()
        {
            return people.FindAll(x => x is Student);
        }

        public List<Person> GetStudents(string search)
        {
            return people.FindAll(x => x is Student && x.Name.ToLower().Contains(search.ToLower()));
        }

        public List<Person> GetLecturers()
        {
            return people.FindAll(x => x is Lecturer);
        }

        public List<Person> GetLecturers(string search)
        {
            return people.FindAll(x => x is Lecturer && x.Name.ToLower().Contains(search.ToLower()));
        }

        //  return a person through ppsn
        public Person GetPerson(string ppsn)
        {
            return people.Find(x => x.PPSN == ppsn);
        }

        public void Add(Person item)
        {
            if (!people.Contains(item))
                people.Add(item);
        }

        public void Clear()
        {
            ((ICollection<Person>)people).Clear();
        }

        public bool Contains(Person item)
        {
            return ((ICollection<Person>)people).Contains(item);
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            ((ICollection<Person>)people).CopyTo(array, arrayIndex);
        }

        public bool Remove(Person item)
        {
            return ((ICollection<Person>)people).Remove(item);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return ((ICollection<Person>)people).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<Person>)people).GetEnumerator();
        }
    }
}
