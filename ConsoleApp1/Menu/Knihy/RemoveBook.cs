using LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
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
}
