/*
CS3910-C1 Module #4 Assignment 
James Brumbaugh
11/20/2022 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int vowelcount = 0;
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            string reverseString = string.Empty;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];
            }
            for (int i = 0; i < reverseString.Length; i++)
            {
                string c = reverseString[i].ToString();
                if ("aeiou".Contains(c))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                
                Console.Write(reverseString[i]);
            }        
            Console.WriteLine();
        }
    }
}
