using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace     
namespace Atmini_ciparu
{
    //main class
    class Program
    {
        static int guess;
        static int answer;
        //Entry point method
        static void Main(string[] args)
        {
            Console.Title = "Atmini ciparu";

            introduction();
            randomize();
            while (true)
            {
                askData();
                display();
                if (guess == answer)
                    break;
            }
            goodBye();

        }
        static void goodBye()
        {
            Console.WriteLine("Thank you for using this application");
            Console.WriteLine("Press any key to end");
            Console.ReadLine();

        }
        static void introduction()

        {
            Console.WriteLine("Sveicināti minēšanas spēlē / Enter any key to countinue!");
            Console.ReadLine();

        }
        static void askData()
        {
            Console.Clear();
             
            while (true)
            {
                Console.WriteLine("Please enter integer between 0-10");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < 0 || guess > 10) 
                    Console.WriteLine("Invalid operation, please enter value with properrange!");
                
                
                    else
                        break;
                
            }
        }
        static void randomize()
        {
            Random random = new Random();
            answer = random.Next(0, 10);
        }
        static void display()
        { if (guess == answer)
            {
                Console.WriteLine("Your answer is correct ! congratulations!!!!!!!!");
            }
            else
            {
                Console.WriteLine("Invalid answer!");
               }
            Console.WriteLine("Press any key to try one more time!");
            Console.ReadLine();

        }
    }
}
