using LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static void ReturnBook()
    {
        List<Kniha> bookList = new List<Kniha>();
        Kniha book = new Kniha();
        Console.WriteLine("Nazov knihy ktoru chces vratit: ");
        book.returnBook = Console.ReadLine();



        if (book.list.Exists(y => y.bookName == returnBook))
        {
            System.Collections.IList list = bookList;
            for (int i = 0; i < list.Count; i++)
            {
                Book addReturnBookCount = (Book)list[i];
            }
        }
    }
}
