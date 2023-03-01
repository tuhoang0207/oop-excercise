using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment.Services;

namespace assignment
{
    internal class Display
    {
        public static void displayBook(List<BookService> books) {
            foreach (BookService book in books)
            {
                Console.WriteLine("book id " + book.bookId);
                Console.WriteLine("book name " + book.bookName);
                Console.WriteLine("book title " + book.genre);
                Console.WriteLine("book quantity " + book.quantity);
                Console.WriteLine("book author " + book.author);
            }
        }

        public static void displayLibraryCard(List<LibraryCardService> libraryCards) {
            foreach(LibraryCardService libraryCard in libraryCards)
            {

            }
        }
    }
}
