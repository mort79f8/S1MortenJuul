using System;
using System.Collections.Generic;
using System.Text;

namespace MortenJuulS1.Classes2.Ex1
{
    class Book
    {
        private string author;
        private string titel;
        private int numberOfPages;
        private string publisher;


        public string Author { get => author; set => author = value; }
        public string Titel { get => titel; set => titel = value; }
        public int NumberOfPages { get => numberOfPages; set => numberOfPages = value; }
        public string Publisher { get => publisher; set => publisher = value; }

        public Book()
        {

        }

        public Book(string author, string titel, int numberOfPages, string publisher)
        {
            Author = author;
            Titel = titel;
            NumberOfPages = numberOfPages;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"{Titel} - {Author}";
        }
    }
}
