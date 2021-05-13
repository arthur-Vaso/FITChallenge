using System;
using System.Collections.Generic;
using System.Text;

namespace FITChallenge.Models
{
    public class Person
    {
        public string name { get; set; }
        public string birthDate { get; set; }
        public double tall { get; set; }

        public int AgeValidation()
        {
            int age = 0;
            if (birthDate != "")
            {
                DateTime userBirth = Convert.ToDateTime(birthDate);
                age = DateTime.Now.Year - userBirth.Year;
                if (DateTime.Now.DayOfYear < userBirth.DayOfYear)
                {
                    age = age - 1;
                }
                return age;
            }
            else
            {
                return -1;
            }
        }
    }
}
