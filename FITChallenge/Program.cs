using System;
using FITChallenge.FileHandler;
using FITChallenge.Models;

namespace FITChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person() { name = "Arthur", birthDate="2222/02/17", tall=1.74 };
            Person person = new Person();

            //Console.WriteLine("age = " + person.AgeValidation().ToString());
            Console.WriteLine("Name");
            person.name = Console.ReadLine().ToString();
            Console.WriteLine("Date of Birthday");
            person.birthDate = Console.ReadLine().ToString();
            Console.WriteLine("Tall");
            person.tall = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Age = " + person.AgeValidation().ToString());
            
            Write.WriteLogFile(person); 

        }
    }
}
