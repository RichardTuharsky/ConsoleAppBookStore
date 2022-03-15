using LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Functionality
{
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
}
