using assignment.Interfaces;
using assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Services
{
    internal class BookService : Book, ILibrary
    {
        public static List<Book> listBooks = new List<Book>();

        public void addNew()
        {
            Book b = new Book();
            int id = listBooks.Count() + 1;

            b.bookId = id;

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
                Console.WriteLine("==============================");
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
            foreach (Book b in listBooks.ToList())
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
                    break;
                }
                else
                {
                    Console.WriteLine("The book you want to search is not found ");
                    break;
                }
            }
        }


        public void analyze()
        {
            //string tempGenre = listBooks[0].genre.ToString();
            int count = 0;
            //int tempCount = 1;
            string tempGenre;
            //foreach(Book b in listBooks)
            //{
            //    if(b.genre.Equals(tempGenre))
            //    {
            //        count++;
            //    }
            //}
            List<String> tempList = new List<String>();
            var result = from book in listBooks
                         group book.bookName by book.genre;
            result.ToList().ForEach(x =>
            { // lặp danh sách genre
                Console.WriteLine($"genre {x.Key}");
                x.ToList().ForEach(y =>
                {
                    Console.WriteLine("book name " + y);
                    //count++;
                });
                Console.WriteLine("there are " + x.Count() + " of " + x.Key);
                //count = 0;
            });
            //for (int i = 0;i < listBooks.Count; i++) {
            //    tempGenre = listBooks[i].genre.ToString();
            //    for (int j = 0; j < listBooks.Count;j++)
            //    {

            //        if (listBooks[j].genre.Equals(tempGenre))
            //        {
            //                tempList.Add(listBooks[j].genre);
            //                count++;
            //        }
            //        else
            //        {
            //            //tempCount++;
            //        }

            //    }
            //    Console.WriteLine("There are " + count + " of " + tempGenre);
            //    count = 0;
            //}

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

        public List<Book> getBooks()
        {
            return listBooks;
        }
    }
}