using System;

namespace DO14.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new MySqlServerCustomerDal(),
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal()
            };

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });
            manager.Add(new Student { Id = 2, FirstName = "Derin", LastName = "Demiroğ", Departmant = "Computer Sciences" });
            manager.Add(new Worker { Id = 3, FirstName = "Metin", LastName = "Demiroğ", Departmant = "Computer Sciences" });
            
        }
    }

    //Soyut Nesne - Tek başına bir işe yaramaz
    //Soyut nesneler tek başına newlenemez yani new dedikten sonra nereye implement yapıldıysa onu yazabiliriz. Örnek olarak IPerson person = new Customer(); gibi
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    //Somut Nesne
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Eklendi: " + person.FirstName);
        }
    }
}
