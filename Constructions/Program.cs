using System;

namespace Constructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");

        }
    }

    class Customer
    {
        //default Constructor
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;

            Console.WriteLine("Yapıcı blok çalıştı");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
