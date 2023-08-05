using System;
using System.Collections.Generic;
using System.Text;

namespace simpleprograms
{
    internal class Library
    {
        Book[] book = new Book[2];
        public Library(Book[] arr)
        {
            book = arr;
        }
        public void BorrowBook(string title)
        {
            int count = 0;
            for (int i = 0; i < book.Length; i++)
            {
                if (book[i].Title.Equals(title))
                {
                    book[i].IsAvailable = false;
                    Console.WriteLine("Borrowed");
                    count++;
                }
            }
            if (count == 0) { Console.WriteLine("Book not Available"); }
        }
        public void ReturnBook(string title)
        {
            for (int i = 0; i < book.Length; i++)
            {
                if (book[i].Title.Equals(title))
                {
                    book[i].IsAvailable = true;
                    Console.WriteLine("Returned");
                }
            }

        }
        public void DisplayBookDetails()
        {
            for (int i = 0; i < book.Length; i++)
            {
                Console.WriteLine("Title :" + book[i].Title + " Author :" + book[i].Author + " Availablity " + book[i].IsAvailable);
            }
        }
    }
}
