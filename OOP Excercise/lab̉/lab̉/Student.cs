using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Student : Person
    {
        public Student()
        {
        }

        public Student(string name, string phoneNumber, string emailAddress) : base(name, phoneNumber, emailAddress)
        {
        }

        public string enrolled { get; set; }

        public override void input()
        {
            base.input();
            Console.WriteLine("enter enroll ");
            enrolled = Console.ReadLine();
        }

        public override void show()
        {
            base.show();
            Console.WriteLine("enroll " + enrolled);
        }

        

    }
}
