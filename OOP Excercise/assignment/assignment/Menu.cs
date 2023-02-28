using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise3lab7
{
    internal class Menu
    {
        public void menu()
        {
            Console.WriteLine("---Welcome to VTC Academy library---");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Manage book");
            Console.WriteLine("2. Manage Library card");
            Console.WriteLine("3. Manage loan book card");
        }

        public void bookMenu()
        {
            Console.WriteLine("Manage Book");
            Console.WriteLine("1. Add new book");
            Console.WriteLine("2. Update info");
            Console.WriteLine("3. Show full list");
        }

        public void libraryCardMenu()
        {
            Console.WriteLine("Library card manage");
            Console.WriteLine("1.Add a new card");
            Console.WriteLine("2.Update info");
            Console.WriteLine("3.Show full list");
        }

        public void loanCardMenu()
        {
            Console.WriteLine("Loan Card manage");
            Console.WriteLine("1.Add a new card");
            Console.WriteLine("2.Show full list");
        }
    }
}
