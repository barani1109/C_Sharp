using System;

namespace Assignment5
{
    class Books
    {
        public string BookName;
        public string AuthorName;

        public Books(string bname, string aname)
        {
            BookName = bname;
            AuthorName = aname;
        }

        public void Display()
        {
            Console.WriteLine("Book: " + BookName + ", Author: " + AuthorName);
        }
    }

    class BookShelf
    {
        private Books[] bookList = new Books[5]; 

        public Books this[int index]
        {
            get { return bookList[index]; }
            set { bookList[index] = value; }
        }
    }

    class Progra
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();

            shelf[0] = new Books("C# Basics", "John");
            shelf[1] = new Books("OOP Concepts", "Smith");
            shelf[2] = new Books("Data Structures", "David");
            shelf[3] = new Books("Algorithms", "Robert");
            shelf[4] = new Books("DotNet Guide", "James");

            Console.WriteLine("Book Details:\n");

            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }

            Console.ReadLine();
        }
    }
}