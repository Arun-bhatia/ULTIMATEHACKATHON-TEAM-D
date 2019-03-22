using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Arun Bhatia(c0732127)
Gagandeep Kaur Waraich(C0731847)
Manpreet Kaur(C0730406)
Parminder Kaur Bhangu(C0730065)
Ravneet Kaur(C0730323)
Isha Garg (c0732132)
Dheeraj Jain(c0723560)
Manjot Kaur(c0732136)
simranjeet kaur(727100)
Gurpreet Gurpreet(712759)
Amanjot Kaur Johal(705466)

     */
namespace Hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] array1 = { "Arun", "Aman", "Dinesh", "Manpreet", "xv", "Gagandeep", "Parminder", "Ravneet", "Manjot", "Isha","Dheeraj","Simran","Gurpreet","Amanjot","joe" };
            for (int i = 0; i <= array1.Length; i++)
                
            {
                if (i == 0 || i == 3 || i == 7 || i == 11 || i == 15)
                {
                    
                    Console.WriteLine("Team A: " + array1[i]);
                }
                else if (i == 1 || i == 4 || i == 8 || i == 12 )
                {
                    Console.WriteLine("Team B: " + array1[i]);
                }
                else if (i == 2 || i == 5 || i == 9 || i == 13)
                {
                    Console.WriteLine("Team C: " + array1[i]);
                }
                else if (i == 3 || i == 6 || i == 10 || i == 14)
                {
                    Console.WriteLine("Team D: " + array1[i]);
                }

            }
        }
    }
}
