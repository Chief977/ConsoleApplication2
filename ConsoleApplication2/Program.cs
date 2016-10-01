using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            p1 = new Person();

            //what is your first name?
            p1.FirstName = "Terrence";

            //what is your last name?
            p1.LastName = "Myhand";

            //what is your age?
            p1.Age = 35;

            p1.Spouse = new Person();
            //what is your spouse's first name?
            p1.Spouse.FirstName = "Momo";

            //what is your spouse's last name?
            p1.Spouse.LastName = "Murasaki";

            //what is your spouse's age?
            p1.Spouse.Age = 25;

            p1.Spouse.LastName = p1.LastName;
            p1.Spouse.Spouse = p1;

            Person p2;
            p2 = new Person();

            //what is your first name?
            p2.FirstName = "Akari";

            //what is your last name?
            p2.LastName = "Aoiyama";

            //what is your age?
            p2.Age = 31;

            p2.Spouse = new Person();
            //what is your spouse's first name?
            p2.Spouse.FirstName = "Kintaro";

            //what is your spouse's last name?
            p2.Spouse.LastName = "Okami";

            //what is your spouse's age?
            p2.Spouse.Age = 33;

            p2.Spouse.LastName = p2.LastName;
            p2.Spouse.Spouse = p2;

            System.Console.WriteLine(p1.GetFullName());
            System.Console.WriteLine(p2.GetFullName());
            System.Console.WriteLine(p1.Spouse.GetFullName());
            System.Console.WriteLine(p2.Spouse.GetFullName());

        }
    }
}
