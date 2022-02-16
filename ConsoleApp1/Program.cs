using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    class Kniha
    {
        public string firstName;
        public string secondName;
        public string bookName;
    }

    class Uzivatel
    {
        public string userName;
        public string userSurName;
    }

    class Program
    {
        static List<Kniha> bookList = new List<Kniha>();
        static Kniha book = new Kniha();

        static void Main(string[] args)
        {
            Console.WriteLine("Vitajte v kniznici !");

            Console.WriteLine("\nMenu\n" +
                   "1)Pridat knihu\n" +
                   "2)Vymazat knihu\n" +
                   "3)Vzhladat knihu\n" +
                   "4)Pozicat knihu\n" +
                   "5)Vratit knihu\n" +
                   "6)Zavriet\n\n");

            Console.Write("Vyberte moznost ktoru si zelate:");

            int option = int.Parse((Console.ReadLine()));

            if (option == 1)
            {
                GetBook();
            }
            else if (option == 2)
            {
                RemoveBook();
            }
            else if 
        }

    }
}


