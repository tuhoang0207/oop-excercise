using assignment.Interfaces;
using assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Services
{
    internal class LoanCardService : LoanCard, ILibrary
    {
        static List<LoanCard> listLoanCard = new List<LoanCard>();
        BookService book = new BookService();
        LibraryCardService libraryCard = new LibraryCardService();
        int id = 1;
        public void addNew()
        {
            List<int> tempList = new List<int>();
            LoanCard lc = new LoanCard();
            
            lc.loanCardId = id;

            Console.WriteLine("enter library card id  ");
            lc.libraryCardId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter book id ");
            lc.bookId = Convert.ToInt32(Console.ReadLine());

            var result = book.getBooks();
            if (result != null)
            {
                foreach (var item in result.ToList())
                {
                    tempList.Add(item.bookId);
                    if (item.bookId == lc.bookId)
                    {
                        lc.bookName = item.bookName;
                    }
                }
            }

            

            lc.dateCreated = DateOnly.FromDateTime(DateTime.Now);


            do
            {
                Console.WriteLine("enter give back date ");
                lc.giveBackDate = DateOnly.Parse(Console.ReadLine());
            } while (lc.giveBackDate < lc.dateCreated);

            listLoanCard.Add(lc);
            id++;
        }

        public void show()
        {
            var result = libraryCard.getLibraryCard();
            
            foreach (var loanCard in listLoanCard)
            {
                
                Console.WriteLine("loan card id " + loanCard.loanCardId);
                if (result != null)
                {
                    foreach (var item in result.ToList())
                    {
                        if (item.cardId == loanCard.libraryCardId)
                        {
                            Console.WriteLine("owner name " + item.ownerName);
                        }
                    }
                }
                Console.WriteLine("book name " + loanCard.bookName);
                Console.WriteLine("date created " + loanCard.dateCreated);
                Console.WriteLine("give back date " + loanCard.giveBackDate);
                Console.WriteLine("========================================");
            }
        }

        public void update()
        {
            string name;
            Console.WriteLine("enter loan card name you want to update ");
            name = Console.ReadLine();

            foreach (var lc in listLoanCard)
            {
                if (lc.bookName.Equals(name))
                {

                    Console.WriteLine("enter date created ");
                    lc.dateCreated = DateOnly.Parse(Console.ReadLine());

                    Console.WriteLine("enter give back date ");
                    lc.giveBackDate = DateOnly.Parse(Console.ReadLine());



                    Console.WriteLine("update successful");
                }
            }
        }

        public void delete()
        {
            string name;
            Console.WriteLine("enter book name you want to delete ");
            name = Console.ReadLine();
            foreach (var lc in listLoanCard.ToList())
            {
                if (lc.bookName.Equals(name))
                {
                    listLoanCard.Remove(lc);
                }
                else
                {
                    Console.WriteLine("The book you want to delete is not found ");
                }
            }
        }

        public void sort()
        { //by name
            listLoanCard.Sort((x, y) => string.Compare(x.bookName, y.bookName));
        }

        public void search()
        {
            string name;
            Console.WriteLine("enter book name you want to search ");
            name = Console.ReadLine();

            foreach (var lc in listLoanCard)
            {
                if (lc.bookName.Equals(name))
                {
                    Console.WriteLine("Found the book you want to search ");
                    Console.WriteLine(lc.bookName + " was found ");
                }
                else
                {
                    Console.WriteLine("The book you want to search is not found ");
                }
            }
        }

        public void analyze()
        {
            //string tempGenre = listBooks[0].genre.ToString();
            //int count = 0;
            //foreach (Book b in listBooks)
            //{
            //    if (b.genre.Equals(tempGenre))
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("There are " + count + " of " + tempGenre);
        }
        public void saveToFile()
        {
            TextWriter tw = new StreamWriter("loancard.txt");

            foreach (var s in listLoanCard)
            {
                tw.WriteLine(s);
            }
            tw.Close();
        }
    }
}
