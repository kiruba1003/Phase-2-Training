using System;
using System.Collections.Generic;
using System.Text;

namespace simpleprograms
{
    internal class Book
    {
        private readonly int bookId;
        private string title;
        private string author;
        private bool isAvailable;

        public Book(int bookId, string title, string author, bool isAvailable)
        {
            this.bookId = bookId;
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

    }
}
