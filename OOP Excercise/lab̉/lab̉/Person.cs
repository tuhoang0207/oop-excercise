namespace lab6
{
    public class Person
    {

        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }

        public Person(string name, string phoneNumber, string emailAddress)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }

        public Person()
        {
        }

        public virtual void input()
        {
            Console.WriteLine("enter name ");
            name = Console.ReadLine();

            Console.WriteLine("enter phone number ");
            phoneNumber = Console.ReadLine();

            Console.WriteLine("enter email address ");
            emailAddress = Console.ReadLine();
        }

        public virtual void show()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("phone number: " + phoneNumber);
            Console.WriteLine("email address: " + emailAddress);
        }

        public override string ToString()
        {
            Console.WriteLine("name " + name + " email " + emailAddress);
            return base.ToString();
        }
    }
}

