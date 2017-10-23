using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace LibraryManagementSystem
{
    //  my json parser for loading test data
    public static class JsonHelper
    {
        //  Returns a list of type "Person" of the people in the colleges/libraries system ( from json )
        public static List<Person> GetPeople()
        {
            //  Parse the "lecturers.json", and "students.json" files
            List<LecturerJsonObject> lecturerJsonObjects = JsonParser<LecturerJsonObject>.JsonToList(Properties.Resources.Lecturers);
            List<StudentJsonObject> studentJsonObjects = JsonParser<StudentJsonObject>.JsonToList(Properties.Resources.Students);

            //  Convert parsed data to Lecturer and Student objects
            List<Person> people = new List<Person>();
            foreach(LecturerJsonObject person in lecturerJsonObjects)
                people.Add(new Lecturer(person.id,person.salary,person.ppsn,person.name,person.address,person.phone,person.email));
            foreach (StudentJsonObject student in studentJsonObjects)
                people.Add(new Student(student.id, student.status, student.ppsn, student.name, student.address, student.phone, student.email));

            //  Combine lecturers and students as type "Person"
            //List<Person> result = lecturers.ConvertAll(x => x as Person);
            //result.AddRange(students.ConvertAll(x => x as Person));

            return people;
        }

        //  Returns a SortedList of books and the quantity of them in the library inventory
        public static List<Book> GetInventory()
        {
            //  The json I generated for books had duplicate titles
            //  Quick and dirty solution to remove the duplicates
            //  The generator couldn't generate unique words / word combinations
            List<Book> inventory = JsonParser<Book>.JsonToList(Properties.Resources.books);
            HashSet<string> titles = new HashSet<string>();
            List<Book> tmp = new List<Book>();
            foreach (Book b in inventory)
                if (!titles.Add(b.Title))
                    tmp.Add(b);
            foreach (Book b in tmp)
                inventory.Remove(b);

            return inventory;
        }

        //  Book doesn't inherit from anything, so serialization is simple
        //private struct BookJsonObject
        //{
        //    public string ISBN { get; set; }
        //    public string Title { get; set; }
        //    public string Author { get; set; }
        //    public string Publisher { get; set; }
        //    public string Category { get; set; }
        //    public string About { get; set; }
        //    public int Quantity { get; set; }
        //}

        //  Because Lecturer and Student inherit from Person, serialization is a struggle
        //  simplest solution I figured was to make tmp data holders, which I then transfer 
        //  to my classes.
        private struct LecturerJsonObject
        {
            public string id { get; set; }
            public decimal salary { get; set; }
            public string ppsn { get; set; }
            public string name { get; set; }
            public string address { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
        }

        private struct StudentJsonObject
        {
            public string id { get; set; }
            public GradStatus status { get; set; }
            public string ppsn { get; set; }
            public string name { get; set; }
            public string address { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
        }

        //  My generic parser, so I don't have to make a bunch of overloaded methods
        private static class JsonParser<T>
        {
            public static List<T> JsonToList(byte[] jsonBytes)
            {
                string json = Encoding.ASCII.GetString(jsonBytes);
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
        }
    }
}
