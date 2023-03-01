using assignment.Interfaces;
using assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Services
{
    internal class LibraryCardService : LibraryCard, ILibrary
    {
        static List<LibraryCard> listLibraryCard = new List<LibraryCard>();

        public void addNew()
        {
            LibraryCard lc = new LibraryCard();


            Console.WriteLine("enter card id ");
            lc.cardId = Console.ReadLine();

            Console.WriteLine("enter owner name  ");
            lc.ownerName = Console.ReadLine();

            Console.WriteLine("enter cmnd id ");
            lc.cmndId = Console.ReadLine();

            Console.WriteLine("enter date created ");
            lc.dateCreated = DateOnly.Parse(Console.ReadLine());

            listLibraryCard.Add(lc);
        }

        public void show()
        {
            foreach (var lc in listLibraryCard)
            {
                Console.WriteLine("card id " + lc.cardId);
                Console.WriteLine("owner name " + lc.ownerName);
                Console.WriteLine("cmnd id " + lc.cmndId);
                Console.WriteLine("date created " + lc.dateCreated);
            }
        }

        public void update()
        {
            string name;
            Console.WriteLine("enter owner name you want to update ");
            name = Console.ReadLine();

            foreach (var lc in listLibraryCard)
            {
                if (lc.ownerName.Equals(name))
                {
                    Console.WriteLine("enter book name ");
                    lc.ownerName = Console.ReadLine();


                    Console.WriteLine("enter cmnd id ");
                    lc.cmndId = Console.ReadLine();

                    Console.WriteLine("enter date created ");
                    lc.dateCreated = DateOnly.Parse(Console.ReadLine());





                    Console.WriteLine("update successful");
                }
            }
        }

        public void delete()
        {
            string name;
            Console.WriteLine("enter owner name you want to delete ");
            name = Console.ReadLine();
            foreach (var lc in listLibraryCard)
            {
                if (lc.ownerName.Equals(name))
                {
                    listLibraryCard.Remove(lc);
                }
                else
                {
                    Console.WriteLine("The owner you want to delete is not found ");
                }
            }
        }

        public void search()
        {
            string name;
            Console.WriteLine("enter owner name you want to search ");
            name = Console.ReadLine();

            foreach (var lc in listLibraryCard)
            {
                if (lc.ownerName.Equals(name))
                {
                    Console.WriteLine("Found the book you want to search ");
                    Console.WriteLine(lc.ownerName + " was found ");
                }
                else
                {
                    Console.WriteLine("The book you want to search is not found ");
                }
            }
        }

        public void sort()
        { //by card id 
            listLibraryCard.Sort((x, y) => string.Compare(x.cardId, y.cardId));
        }

        public void saveToFile()
        {
            TextWriter tw = new StreamWriter("librarycard.txt");

            foreach (var s in listLibraryCard)
            {
                tw.WriteLine(s);
            }
            tw.Close();
        }
    }
}