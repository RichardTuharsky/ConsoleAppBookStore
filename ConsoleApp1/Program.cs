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

    class Zapozicanie
    {
        public int userId;
        public string userName;
        public string borrowBookName;
        public DateTime borrowDate;
        public int borrowCount;
    }

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

    }
    public static void GetBook()
    {
        Kniha book = new Kniha();
        Console.WriteLine(" Meno autora: ");
        book.firstName = Console.ReadLine();
        Console.WriteLine(" Priezvisko autora: ");
        book.secondName = Console.ReadLine();
        Console.WriteLine("Nazov knihy: ");
        Console.Write("Book Name:");
        book.bookName = Console.ReadLine();
    }


    public static void RemoveBook()
    {
        Kniha book = new Kniha();
        Console.WriteLine("Zadaj nazov knihy ktoru chces vymazat: ");
        int Del = int.Parse(Console.ReadLine());

        if (bookList.Exists(x => x.bookName == Del))
        {
            book.List.RemoveAt(Del - 1);
            Console.WriteLine("Kniha - {0} bola vymazana.", Del);
        }
        else
        {
            Console.WriteLine("Nespravny nazov knihy. ");
        }
        book.List.Add(book);
        
    }
    public static void SearchBook()
    {
        Kniha book = new Kniha();
        Console.WriteLine("Vyhladaj knihu podla nazvu: ");
        int find = int.Parse(Console.ReadLine());   
        if (bookList.Exists(x => x.bookName == find))
        {
            foreach (Kniha searchId in bookList)
            {
                if (searchId.bookName == find)
                {
                    Console.WriteLine("Nazov knihy: {1}\n", searchId.bookName);
                    
                }
            }
        }
        else
        {
            Console.WriteLine("Knihu s nazvom {1} sa nam nepodarilo najst",find);
        }
    }

    public static void Borrow()
    {
        Kniha book = new Kniha();
        Zapozicanie pozicanie = new Zapozicanie();
        Console.WriteLine("Name: ");

        pozicanie.bookName = Console.ReadLine();

        Console.WriteLine("Nazov knihy ktoru chcete pozicat: ");
        pozicanie.borrowBookName = Console.ReadLine();

        if (book.List.Exists(x => bookName == pozicanie.borrowBookName))
        {
            borrowList.Add(pozicanie);
        }
        else
        {
            Console.WriteLine("Knihu s nazvom{1} sa nevedeli najst");
        }
    }

    public static void ReturnBook()
    {
        Kniha book = new Kniha();
        Console.WriteLine("Nazov knihy ktoru chces vratit: ");
        book.returnBook = Console.ReadLine();
        
        

        if (book.List.Exists(y => y.bookName == returnBook))
        {
            foreach (Book addReturnBookCount in bookList)
            {
                
            }
        }
    }
}


