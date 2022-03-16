using ConsoleApp1.Menu.User;
using LibraryManagement;
using System;
using System.Collections.Generic;


namespace ConsoleApp1.Menu.Knihy
{
    public static void Borrow()
    {
        List<Kniha> bookList = new List<Kniha>();
        List<Zapozicanie> borrowList = new List<Zapozicanie>();
        Book book = new Book();
        BorrowDetails borrow = new BorrowDetails();
        Console.Write("Name :");


        Console.Write("Book id :");
        borrow.borrowBookId = int.Parse(Console.ReadLine());
        Console.Write("Number of Books : ");
        borrow.borrowCount = int.Parse(Console.ReadLine());

        if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
        {
            foreach (Book searchId in bookList)
            {
                if (searchId.bookCount >= searchId.bookCount - borrow.borrowCount && searchId.bookCount - borrow.borrowCount >= 0)
                {
                    if (searchId.bookId == borrow.borrowBookId)
                    {
                        searchId.bookCount = searchId.bookCount - borrow.borrowCount;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Only {0} books are found", searchId.bookCount);
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
        }
        borrowList.Add(borrow);
    }
}
   
