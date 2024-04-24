using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Person
    {
        private static int idCounter = 1;

        public int Id { get; }
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        public Person(string name, string surname, int age)
        {
            Id = idCounter++;
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}