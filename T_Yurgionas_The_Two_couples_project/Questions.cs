using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Yurgionas_The_Two_couples_project
{
    class Question
    {
        public static string AskForString(string prompt)
        {
            System.Console.Write(prompt.PadRight(40) + " : ");
            return System.Console.ReadLine();
        }
        public static int AskForIntegar(string prompt)
        {
            return int.Parse(AskForString(prompt));
        }
        

        
    } 
}
