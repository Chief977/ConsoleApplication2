using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public string AverageAge;

        public static double SumOfAllAges = 35 + 25 + 31 + 33;

        public void PrintFullNameAndAge()

        {
            System.Console.WriteLine(FirstName);
            System.Console.WriteLine(LastName);
            System.Console.WriteLine(Age);

        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
