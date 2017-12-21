using System;

namespace smartercalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //izveido kalkulatora objektu

            //paprasit lietotajam ievadi
            Console.WriteLine("please enter darbiba");
            string input = Console.ReadLine();
            //"1 + 5 - 4" skaits ir 6 pēdējā simbola pozīcija ir 4
            //"1+" skaits ir 2 pēdējās pozīcija ir 1
            int result;
            int counter = 0;
            while (counter < input.Length)
            {
                char symbol = input[counter];
                if (symbol == '+')
                {
                    Console.WriteLine(("plus"));
                }
                else 
                {
                    int number;
                    number = Int32.Parse(symbol.ToString());
                    Console.WriteLine("number" + number);
                }

                counter = counter + 1;

            }
        }
    }
}
