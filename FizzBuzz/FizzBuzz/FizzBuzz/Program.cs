using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Program
    {
        public static void FizzBuzz(int number)
        {// ar if nosakām ja skaitlis dalās ar 3 un 5 tad izvadām fizzbuzz
            if (number%3 == 0 && number%5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }// ja skaitlis dalās ar 3, izvadām fizz
            else if (number%3 == 0)
            {
                Console.WriteLine("Fizz");
            }// ja skaitlis dalās ar 5 izvadam buzz
            else if (number%5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
                Console.ReadLine();
                
            }
        }

        private static void Main(string[] args)
        {// funkcija kas padod skaitlus izpildei līdz 50
            for (int i = 0; i <= 50; i++)
                                   
                           {   
                FizzBuzz(i);
               
            }
           
       
        }
    }
}