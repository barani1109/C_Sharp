using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
  
    class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book: {BookName}, Author: {AuthorName}");
        }
    }

    class BookShelf
    {
        private Books[] books = new Books[5];

        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public void DisplayAll()
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                    books[i].Display();
            }
        }
    }

    internal class Question1
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();
            shelf[0] = new Books("The Alchemist", "Paulo Coelho");
            shelf[1] = new Books("Harry Potter", "J.K. Rowling");
            shelf[2] = new Books("Wings of Fire", "A.P.J. Abdul Kalam");
            shelf[3] = new Books("Think and Grow Rich", "Napoleon Hill");
            shelf[4] = new Books("Rich Dad Poor Dad", "Robert Kiyosaki");
            shelf.DisplayAll();
            Console.ReadLine();
        }
    }
}