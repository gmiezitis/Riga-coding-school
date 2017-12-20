using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // izveidot kalkulēšanas objektu
            calculations calc;
            calc = new calculations();
            //paprsīt lietotājam vērtību
            int firstNumber = calc.AskUserforNumbers();

            //paprsīt lietotājam otru vētrību

            int secondNumber = calc.AskUserforNumbers();

            //paprasīt lietotājam otru vērtību

            //saskaita
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
