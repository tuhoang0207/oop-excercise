﻿using assignment.Interfaces;
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
            foreach (var loanCard in listLoanCard)
            {
                Console.WriteLine("loan card id " + loanCard.loanCardId);
                Console.WriteLine("library card " + loanCard.bookName);
                Console.WriteLine("book name " + loanCard.bookName);
                Console.WriteLine("book id " + loanCard.bookId);
                Console.WriteLine("date created " + loanCard.dateCreated);
                Console.WriteLine("give back date " + loanCard.giveBackDate);
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
            TextWriter tw = new StreamWriter("loancard.txt");

            foreach (var s in listLoanCard)
            {
                tw.WriteLine(s);
            }
            tw.Close();
        }
    }
}
