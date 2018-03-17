using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Yurgionas_The_Two_couples_project
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.GatherDataFromUser();

            Person p2 = new Person();
            p2.GatherDataFromUser();





            System.Console.WriteLine("Printing Results...   ");
            System.Console.WriteLine("------------------------------------------------------");
            System.Console.WriteLine(p1.LastName + ", " + p1.FirstName + " (" + p1.Age + ")");
            System.Console.WriteLine(p1.LastName + ", " + p1.Spouse.FirstName + "(" + p1.Spouse.Age + ")");
            System.Console.WriteLine(p2.LastName + ", " + p2.FirstName + " (" + p2.Age + ")");
            System.Console.WriteLine(p2.LastName + ", " + p2.Spouse.FirstName + "(" + p2.Spouse.Age + ")");
            System.Console.WriteLine("------------------------------------------------------");
            System.Console.WriteLine("Average Age: " + (double)Person.SumOfAllAges/(double)4);
            System.Console.WriteLine("------------------------------------------------------");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}

