using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise3lab7
{
    internal class LoanCard : ILibrary
    {
        public LoanCard()
        {
        }

        public string loanCardId { get; set; }
        public string libraryCardId { get; set; }
        public string bookName{ get; set; }
        public string bookId{ get; set; }
        public DateOnly dateCreated { get; set; }

        public DateOnly giveBackDate { get; set; }
        static List<LoanCard> listLoanCard = new List<LoanCard>();

        public LoanCard(string loanCardId, string libraryCardId, string bookName, string bookId, DateOnly dateCreated, DateOnly giveBackDate)
        {
            this.loanCardId = loanCardId;
            this.libraryCardId = libraryCardId;
            this.bookName = bookName;
            this.bookId = bookId;
            this.dateCreated = dateCreated;
            this.giveBackDate = giveBackDate;
        }

        public void addNew()
        {
            LoanCard lc = new LoanCard();

      
            Console.WriteLine("enter loan card id ");
            lc.loanCardId = Console.ReadLine();

            Console.WriteLine("enter library card id  ");
            lc.libraryCardId = Console.ReadLine();

            Console.WriteLine("enter book name ");
            lc.bookName = Console.ReadLine();

            Console.WriteLine("enter book id ");
            lc.bookId = Console.ReadLine();

            Console.WriteLine("enter loan date  ");
            lc.dateCreated = DateOnly.Parse(Console.ReadLine());

            Console.WriteLine("enter give back date ");
            lc.giveBackDate = DateOnly.Parse(Console.ReadLine());

            listLoanCard.Add(lc);
        }

        public void show()
        {
            foreach (var book in listLoanCard)
            {
                Console.WriteLine("loan card id " + loanCardId);
                Console.WriteLine("library card " + bookName);
                Console.WriteLine("book name " + bookName);
                Console.WriteLine("book id " + bookId);
                Console.WriteLine("date created " + dateCreated);
                Console.WriteLine("give back date " + giveBackDate);
            }
        }

        public void update()
        {
            string name;
            Console.WriteLine("enter book name you want to update ");
            name = Console.ReadLine();

            foreach (var lc in listLoanCard)
            {
                if (lc.bookName.Equals(name))
                {
                    Console.WriteLine("enter book name ");
                    lc.bookName = Console.ReadLine();

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
            foreach (var lc in listLoanCard)
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

        public void saveToFile()
        {
            throw new NotImplementedException();
        }
    }
}
