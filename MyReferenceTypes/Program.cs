using System;

namespace MyReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal personal1 = new Personal();
            personal1.Id = 0001;
            personal1.FirstLastName = "Ahmet Şahin";

            Customer customer1 = new Customer();
            customer1.Id = 0002;
            customer1.FirstLastName = "Selami Şahan";
            customer1.CreditCardNumber = 1234567890;

            Employee employee1 = new Employee();
            employee1.Id = 0003;
            employee1.EmployeeNumber = 0003;
            employee1.FirstLastName = "Ramiz Karakuş";
            employee1.Department = "IT Support";

            personal1 = customer1;
            Console.WriteLine(personal1.FirstLastName);
            Console.WriteLine(((Customer)personal1).CreditCardNumber);
            Console.WriteLine("////");
            personal1 = employee1;
            Console.WriteLine(personal1.FirstLastName);
        }
    }

    class Personal
    {
        public int Id { get; set; }
        public string FirstLastName { get; set; }

    }

    class Customer : Personal
    {
        public int CreditCardNumber { get; set; }

    }
    class Employee : Personal
    {
        public int EmployeeNumber { get; set; }
        public string Department { get; set; }
    }
}