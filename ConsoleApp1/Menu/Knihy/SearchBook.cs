using ConsoleApp1.Menu.Book;
using LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menu.User
{

    public static void SearchBook()
    {

        
        List<Kniha> bookList = new List<Kniha>();
        Book book = new Book();
        Console.Write("Search by BOOK ID :");
        int find = int.Parse(Console.ReadLine());

        if (bookList.Exists(x => x.bookId == find))
        {
            System.Collections.IList list = bookList;
            for (int i = 0; i < list.Count; i++)
            {
                Book searchId = (Book)list[i];
                if (searchId.bookId == find)
                {
                    Console.WriteLine("Book id :{0}\n" +
                    "Book name :{1}\n" +
                    "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookCount);
                }
            }
        }
        else
        {
            Console.WriteLine("Book id {0} not found", find);
        }
    }
}

