using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
