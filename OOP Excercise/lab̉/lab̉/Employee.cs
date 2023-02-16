using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Employee : Person
    {
        public string department{ get; set; }
        public double salary { get; set; }
        public DateOnly dateHired{ get; set; }
        
        public Employee() { }

        public Employee(string name, string phoneNumber, string emailAddress) : base(name, phoneNumber, emailAddress)
        {

        }

        public virtual void CalculateBonus()
        {

        }

        public virtual void CalculateVacation()
        {

        }

        public override void input()
        {
            base.input();
            Console.WriteLine("enter department ");
            department = Console.ReadLine();

            Console.WriteLine("enter salary ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter date ");
            dateHired = DateOnly.Parse(Console.ReadLine());
        }

        public override void show()
        {
            base.show();
            Console.WriteLine("department: " + department);
            Console.WriteLine("salary: " + salary);
            Console.WriteLine("date hired: " + dateHired);
        }
    }
}
