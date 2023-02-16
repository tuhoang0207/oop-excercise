using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Faculty : Employee
    {
        public Faculty()
        {
        }

        public Faculty(string name, string phoneNumber, string emailAddress) : base(name, phoneNumber, emailAddress)
        {
        }

        public int officeHours { get; set; }
        public int rank { get; set; }


        public override void input()
        {
            base.input();
            Console.WriteLine("enter office hours ");
            officeHours = Convert.ToInt32(officeHours);

            Console.WriteLine("enter rank ");
            rank = Convert.ToInt32(rank);
        }

        public override void show()
        {
            base.show();
            Console.WriteLine("office hours " + officeHours);
            Console.WriteLine("rank " + rank);
        }


        public override void CalculateBonus()
        {
            double bonus;
            base.CalculateBonus();
            bonus = 1000 + 0.05 * salary;
            Console.WriteLine(bonus);
        }

        public override void CalculateVacation()
        {
            int weeks;
            if (DateTime.Now.Year - dateHired.Year > 3)
            {
                weeks = 5;
                if (DateTime.Now.Year - dateHired.Year > 3 && department.Equals("Senior Lecturer"))
                {
                    weeks = 6;
                }
            } else
            {
                weeks = 4;
            }
            Console.WriteLine(weeks);
            base.CalculateVacation();
        }
    }
}
