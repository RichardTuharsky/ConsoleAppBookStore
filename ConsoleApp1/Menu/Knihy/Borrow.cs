using ConsoleApp1.Menu.User;
using LibraryManagement;
using System;
using System.Collections.Generic;


namespace ConsoleApp1.Menu.Knihy
{
    public static void Borrow(Zapozicanie borrow)
    {
        List<Kniha> bookList = new List<Kniha>();
        List<Zapozicanie> borrowList = new List<Zapozicanie>();

        User.Book book = new User.Book();
        BorrowDetails borrow = new BorrowDetails();

        Console.WriteLine("User id : {0}", borrow.userId = borrowList.Count + 1);
        Console.Write("Name :");
        borrow.userName = Console.ReadLine();

        Console.Write("Book id :");
        borrow.borrowBookId = int.Parse(Console.ReadLine());
        Console.Write("Number of Books : ");
        borrow.borrowCount = int.Parse(Console.ReadLine());

        if (bookList.Exists(x => x.bookId == borrow.borrowBookId))
        {
            System.Collections.IList list = bookList;
            for (int i = 0; i < list.Count; i++)
            {
                User.Book searchId = (User.Book)list[i];
                if (searchId.bookCount >= searchId.book.Count - borrow.borrowCount && searchId.book.Count - borrow.borrowCount >= 0)
                {
                    if (searchId.bookId == borrow.borrowBookId)
                    {
                        searchId.book.Count = searchId.bookCount - borrow.borrowCount;
                        break;
                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("Only {0} books are found", searchId.book.Count);
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
