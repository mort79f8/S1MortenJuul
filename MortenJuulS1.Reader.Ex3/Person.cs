using System;
using System.Collections.Generic;
using System.Text;

namespace MortenJuulS1.Reader.Ex3
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }

        public Person()
        {

        }

        public Person(string name, string lastName, int age)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
        }
    }
}
