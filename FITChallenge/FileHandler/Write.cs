using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using FITChallenge.Models;

namespace FITChallenge.FileHandler
{
    public class Write
    {
        public static void WriteLogFile(Person person)
        {
            string text = String.Format("Name: {0}, BirthDate: {1}, Tall: {2}, Age: {3}\n", person.name, person.birthDate, person.tall, person.AgeValidation().ToString()) ;

            File.AppendAllText("log.txt", text);
        }
    }
}
