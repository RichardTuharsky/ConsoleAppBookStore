
using LibraryManagement;
using System;
using System.Collections.Generic;


namespace ConsoleApp1.Functionality.Menu
{
    public static void Borrow(Zapozicanie borrow)
    {
        Book book = new Book();
        BorrowDetails borrow = new BorrowDetails();
        Console.WriteLine("User id : {0}", (borrow.userId = borrowList.Count + 1));
        Console.Write("Name :");
        borrow.userName = Console.ReadLine();

        Console.Write("Book id :");
        borrow.borrowBookId = int.Parse(Console.ReadLine());
        Console.Write("Number of Books : ");
        borrow.borrowCount = int.Parse(Console.ReadLine());
        Console.Write("Address :");
        borrow.userAddress = Console.ReadLine();
        borrow.borrowDate = DateTime.Now;
        Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());

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
