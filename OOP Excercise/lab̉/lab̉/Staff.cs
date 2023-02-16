using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Staff : Employee
    {
        public Staff()
        {
        }

        public Staff(string name, string phoneNumber, string emailAddress) : base(name, phoneNumber, emailAddress)
        {
        }

        public string title{ get; set; }

        public override void input()
        {
            base.input();
            Console.WriteLine("enter title ");
            title = Console.ReadLine();
        }
        public override void show()
        {
            base.show();
            Console.WriteLine("title " + title);
        }

        public override void CalculateBonus()
        {
            double bonus;
            base.CalculateBonus();
            bonus = 0.06 * salary;
            Console.WriteLine(bonus);
        }

        public override void CalculateVacation()
        {
            int weeks;
            if (DateTime.Now.Year - dateHired.Year >= 5)
            {
                weeks = 4;
            }
            else
            {
                weeks = 3;
            }
            Console.WriteLine(weeks);
            base.CalculateVacation();
        }
    }
}
