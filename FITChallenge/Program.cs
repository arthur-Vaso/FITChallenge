using System;
using FITChallenge.FileHandler;
using FITChallenge.Models;

namespace FITChallenge
{
    class Program
    {
        private static bool firstValidation = true;
        private static bool secondValidation = true;
        private static bool valid;
        private static string day;
        private static string month;
        private static string year;

        static void Main(string[] args)
        {
            Person person = new Person();

            do
            {
                Console.WriteLine("Name");
                person.name = Console.ReadLine().ToString();
                Console.WriteLine("Date of Birthday (Year/Month/Day)");

                Console.WriteLine("Day");
                do
                {
                    day = Console.ReadLine();
                    if(double.Parse(day) >= 1 && double.Parse(day) <= 31)
                    {
                        valid = false;
                    }else
                    {
                        Console.WriteLine("Invalid day!\nType again.");
                        valid = true;
                    }

                } while (valid);

                Console.WriteLine("Month");
                do
                {
                    month = Console.ReadLine();
                    if (double.Parse(month) >=1 && double.Parse(month) <= 12)
                    {
                        valid = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid month!\nType again.");
                        valid = true;
                    }

                } while (valid);
                
                Console.WriteLine("Year" + DateTime.Now.Year);
                do
                {
                    year = Console.ReadLine();
                    if (double.Parse(year) > 1900 && double.Parse(year) <= DateTime.Now.Year)
                    {
                        valid = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid year!\nType again.");
                        valid = true;
                    }

                } while (valid);
                

                person.birthDate = year + "/" + month + "/" + day;
                
                Console.WriteLine("Tall");
                person.tall = double.Parse(Console.ReadLine());

                Console.WriteLine("Age = " + person.AgeValidation().ToString());

                Write.WriteLogFile(person);


                Console.WriteLine("Do you want to add 1 more person? (Y/N)");
                do
                {
                    var answer = Console.ReadLine();
                    answer = answer.ToUpper();

                    if (!answer.Equals("Y"))
                    {
                        if (answer.Equals("N"))
                        {
                            firstValidation = false;
                            secondValidation = false;
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer!\nPlease answer again (Y/N).");
                            firstValidation = true;
                        }
                    }
                    else
                    {
                        firstValidation = false;
                        Console.Clear();
                    }
                } while (firstValidation);
            } while (secondValidation);

        }
    }
}
