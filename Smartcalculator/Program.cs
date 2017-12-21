using System;

namespace Smartcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            float answer;

            Console.WriteLine("Ievadi lūdzu pirmo numuru:\n");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ludzu izvēlaties operacijas (+, *, -, /):\n");
            operand = Console.ReadLine();

            Console.WriteLine("Ievadi lūdzu pirmo numuru:\n");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operand)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;

                case "-":
                    answer = num1 - num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;
                default:
                    answer = 0;
                    break;


            }
            Console.WriteLine("Atbilde ir :\n" + num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
            Console.ReadLine();
        }
    }
}
