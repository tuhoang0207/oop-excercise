using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Book : ILibrary
    {
        public string bookId { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
        public int quantity { get; set; }
        public string genre { get; set; }

        static List<Book> listBooks = new List<Book>();
        public Book()
        {
        }
        public Book(string bookId, string bookName, string author, int quantity, string genre)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.author = author;
            this.quantity = quantity;
            this.genre = genre;
        }

        public void addNew()
        {
            Book b = new Book();

            Console.WriteLine("enter book id ");
            b.bookId = Console.ReadLine();

            Console.WriteLine("enter book name ");
            b.bookName = Console.ReadLine();

            Console.WriteLine("enter author name ");
            b.author = Console.ReadLine();

            Console.WriteLine("enter quantity ");
            b.quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("enter genre ");
            b.genre = Console.ReadLine();

            listBooks.Add(b);
        }

        public void show()
        {
            foreach (var book in listBooks)
            {
                Console.WriteLine("book id " + book.bookId);
                Console.WriteLine("book name " + book.bookName);
                Console.WriteLine("author name " + book.author);
                Console.WriteLine("quantity " + book.quantity);
                Console.WriteLine("genre " + book.genre);
            }
        }

        public void update()
        {
            string name;
            Console.WriteLine("enter book name you want to update ");
            name = Console.ReadLine();

            foreach (Book b in listBooks)
            {
                if (b.bookName.Equals(name))
                {
                    Console.WriteLine("enter book name ");
                    b.bookName = Console.ReadLine();

                    Console.WriteLine("enter author name ");
                    b.author = Console.ReadLine();

                    Console.WriteLine("enter quantity ");
                    b.quantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter genre ");
                    b.genre = Console.ReadLine();

                    Console.WriteLine("update successful");
                }
            }
        }

        public void delete()
        {
            string name;
            Console.WriteLine("enter book name you want to delete ");
            name = Console.ReadLine();
            foreach (Book b in listBooks)
            {
                if (b.bookName.Equals(name))
                {
                    listBooks.Remove(b);
                }
                else
                {
                    Console.WriteLine("The book you want to delete is not found ");
                }
            }
        }

        public void sort()
        { //by name
            listBooks.Sort((x, y) => string.Compare(x.bookName, y.bookName));
        }

        public void search()
        {
            string name;
            Console.WriteLine("enter book name you want to search ");
            name = Console.ReadLine();

            foreach (Book b in listBooks)
            {
                if (b.bookName.Equals(name))
                {
                    Console.WriteLine("Found the book you want to search ");
                    Console.WriteLine(b.bookName + " of " + b.author);
                }
                else
                {
                    Console.WriteLine("The book you want to search is not found ");
                }
            }
        }

        public void saveToFile()
        {
            TextWriter tw = new StreamWriter("book.txt");

            foreach (var s in listBooks)
            {
                tw.WriteLine("book id " + s.bookId);
                tw.WriteLine("book name " + s.bookName);
                tw.WriteLine("author " + s.author);
                tw.WriteLine("quantity " + s.quantity);
                tw.WriteLine("genre " + s.genre);
            }
            Console.WriteLine("Write to file successfully");
            tw.Close();
        }
    }
}
