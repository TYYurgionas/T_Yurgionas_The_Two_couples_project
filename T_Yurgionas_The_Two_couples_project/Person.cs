using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Yurgionas_The_Two_couples_project
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        public static int SumOfAllAges;






        public void GatherDataFromUser()
        {
            this.FirstName = Question.AskForString("Your First Name");
            this.LastName = Question.AskForString("Your Last Name");
            this.Age = Question.AskForIntegar("Your age");
            SumOfAllAges += this.Age;


            System.Console.Write("Are you Married? " + " ( y/n ) ");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                this.Spouse.FirstName = Question.AskForString("Your First Name");
                this.Spouse.Age = Question.AskForIntegar("Your age");
                SumOfAllAges += this.Spouse.Age;
            }
        }







    }
}
