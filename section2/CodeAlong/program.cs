using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.writeLine("Hi {0}, I am {1}", to, Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.New = "John";
            person.Introduce("Mosh")
        }
    }
}