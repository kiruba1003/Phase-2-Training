using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleprograms
{
    internal class Library
    {
        public static ArrayList book = new ArrayList();

        public void BorrowBook(string title)
        {
            Book.LendItem(title);
        }
        public void ReturnBook(string title)
        {
            foreach (Book i in book)
            {
                if (i.Title.Equals(title))
                {
                    i.IsAvailable = true;
                    Console.WriteLine(" Book Returned");
                }
            }

        }
        public void DisplayBookDetails()
        {
            foreach (Book i in book)
            {
                Console.WriteLine("Title :" + i.Title + " Author :" + i.Author + " Availablity " + i.IsAvailable);
            }
        }
    }
}
