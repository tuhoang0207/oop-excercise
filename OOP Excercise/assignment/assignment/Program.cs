using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment.Services;

namespace assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            int choice;
           

            do
            {
                menu.menu();
                Console.WriteLine("enter any choice ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        BookService b = new BookService();
                        do
                        {
                            menu.bookMenu();
                            Console.WriteLine("enter any choice");
                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    b.addNew();
                                    b.show();
                                    break;
                                case 2:
                                    b.show();
                                    break;
                                case 3:
                                    b.update();
                                    b.show();
                                    break;
                                case 4:
                                    b.delete();
                                    b.show();
                                    break;
                                case 5:
                                    b.search();
                                    break;
                                case 6:
                                    b.sort();
                                    b.show();
                                    break;
                                case 7:
                                    b.saveToFile();
                                    break;
                                case 8:
                                    b.analyze();
                                    break;
                            }
                            break;
                        } while (choice != 0);
                        break;
                    case 2:
                        LibraryCardService l = new LibraryCardService();
                        do
                        {
                            menu.libraryCardMenu();
                            Console.WriteLine("enter any choice");
                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    l.addNew();
                                    break;
                                case 2:
                                    l.update();
                                    break;
                                case 3:
                                    l.show();
                                    break;
                                case 4:
                                    l.delete();
                                    break;
                                case 5:
                                    l.search();
                                    break;
                                case 6:
                                    l.sort();
                                    l.show();
                                    break;
                                case 7:
                                    l.saveToFile();
                                    break;
                            }
                            break;
                        } while (choice != 0);
                        break;
                    case 3:

                        LoanCardService lc = new LoanCardService();
                        do
                        {
                            menu.loanCardMenu();
                            Console.WriteLine("enter any choice");
                            choice = Convert.ToInt32(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    lc.addNew();
                                    break;
                                case 2:
                                    lc.update();
                                    break;
                                case 3:
                                    lc.show();
                                    break;
                                case 4:
                                    lc.delete();
                                    break;
                                case 5:
                                    lc.search();
                                    break;
                                case 6:
                                    lc.sort();
                                    lc.show();
                                    break;
                                case 7:
                                    lc.saveToFile();
                                    break;
                            }
                            break;
                        } while (choice != 0);
                        break;
                    default:
                        Console.WriteLine("choose a correct option");
                        break;
                }
            } while (choice != 0);
        }
    }
}
