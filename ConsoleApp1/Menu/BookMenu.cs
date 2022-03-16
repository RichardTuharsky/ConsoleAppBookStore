using ConsoleApp1.Menu.Knihy;
using LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<Kniha> bookList = new List<Kniha>();
        static List<Zapozicanie> borrowList = new List<Zapozicanie>();
        static Kniha book = new Kniha();
        static Zapozicanie borrow = new Zapozicanie();

        static void Main(string[] args)
        {
            Console.WriteLine("Vitajte v kniznici !");

            Console.WriteLine("\nMenu\n" +
                   "1)Pridat knihu\n" +
                   "2)Vymazat knihu\n" +
                   "3)Vyhladat knihu\n" +
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
            else if (option == 3)
            {
                SearchBook();
            }
            else if (option == 4)
            {
                Borrow();
            }
            else if (option == 5)
            {
                ReturnBook();
            }
            else if (option == 6)
            {
                Console.WriteLine("Dakujeme za navstevu");

            }
            else
            {
                Console.WriteLine("Moznost neexistuje\n");
            }

        }
        //zavolanie funkcii
        private static void ReturnBook()
        {
            throw new NotImplementedException();
        }

        private static void Borrow()
        {
            throw new NotImplementedException();
        }

        private static void SearchBook()
        {
            throw new NotImplementedException();
        }

        private static void RemoveBook()
        {
            throw new NotImplementedException();
        }

        private static void GetBook()
        {
            throw new NotImplementedException();
        }
    }
}
