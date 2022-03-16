using ConsoleApp1.Menu.Knihy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menu.User
{
    public class Book
    {
        public int bookId;
        public string bookName;
        public int bookCount;
    }

    public class BorrowDetails
    {
        public int borrowBookId;
        public int borrowCount;

    }
}
