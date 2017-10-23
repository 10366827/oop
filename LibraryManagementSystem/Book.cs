using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    //  Book class representing a Book object, including the quantity stocked
    public class Book:IComparable<Book>, IEquatable<Book>
    {
        //  Private Variables
        private string isbn, title, author, publisher, category;
        private int totalQuantity;

        //  Accessors and Mutators
        public string ISBN { get => isbn; private set => isbn = value; }
        public string Title { get => title; private set => title = value; }
        public string Author { get => author; private set => author = value; }
        public string Publisher { get => publisher; private set => publisher = value; }
        public string Category { get => category; private set => category = value; }
        public int TotalQuantity { get => totalQuantity; private set => totalQuantity = value; }

        //  Constructor(s)
        public Book(string isbn, string title, string author, string publisher, string category, int quantity)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Publisher = publisher;
            Category = category;
            TotalQuantity = quantity;
        }

        //  More of the book added to inventory
        public void AddQuantity(int quantity)
        {
            if(quantity > 0)
                TotalQuantity += quantity;
        }

        //  A number of the books removed from inventory
        public void RemoveQuantity(int quantity)
        {
            TotalQuantity -= quantity;
            if (TotalQuantity < 0)
                TotalQuantity = 0;
        }
        
        //  For potential searching
        public string Concat()
        {
            return string.Concat(isbn,title,author,publisher,category);
        }

        public int CompareTo(Book other)
        {
            return isbn.CompareTo(other.isbn);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Book))
                return false;
            return Equals(obj as Book);
        }

        public bool Equals(Book other)
        {
            return isbn == other.isbn;
        }

        public override int GetHashCode()
        {
            return isbn.GetHashCode();
        }

        //public string ToJson()
        //{
        //    return string.Format("{\n\t\"isbn\": \"{0}\"\n\t\"title\": \"{1}\"\n\t\"author\": \"{2}\"\n\t\"publisher\": \"{3}\"\n\t\"category\": \"{4}\"\n\t\"category\": \"{5}\"\n\t\n}",
        //        isbn, title, author, publisher, category, TotalQuantity);
        //}

        public override string ToString()
        {
            return string.Format("'{0,-20} Author:{1}", string.Concat(title,"'"), author);
        }
    }
}
