using System;

namespace Constructors
{
    class Constructor
    {
        string name;
        string secondname;
        string city;
        string street;
        int age;

        public Constructor() // Our default constructor
        {
            name = "Default";
            secondname = "Default";
            city = "Default";
            street = "Default";
            age = 0;
            Console.WriteLine("Default constructor works!");
        }

        public Constructor(string name, string secondname, string city, string street, int age) // we can define all parameters
        {
            this.name = name;
            this.secondname = secondname;
            this.city = city;
            this.street = street;
            this.age = age;
            Console.WriteLine("Constructor with all parameters works!");
        }

        public Constructor(string name, string secondname, int age) // we can also define just a few parameters
        {
            this.name = name;
            this.secondname = secondname;
            this.age = age;
            Console.WriteLine("Constructor with 3 parameters works!");
        }

        public Constructor(string name, string secondname) : this(name, secondname, "Los Angeles", "Hollywood", 22) // We can define just a few parameters like above us but we can refer to an existing constructor and add other values by yourself
        {
            Console.WriteLine("and Constructor with 2 parameters works!");
        }
    }
}
