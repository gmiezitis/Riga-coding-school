using System;
namespace calculator
{
    public class calculations
    {
        public int AskUserforNumbers()
        {
            //izvadīt tekstu, kas paprasa ciparu
            Console.WriteLine("please enter number:");

            //ielasīt ciparu no konsoles
            //iveido mainīgo kas glabās tekstu
            int number;
            //ieraksti tekstu
            string inputText = Console.ReadLine();
            // pārveido lietotāja tekstu par ciparu
            bool success = Int32.TryParse(inputText, out number);

            if (success == false)
            {
                Console.WriteLine("Sorry wrong value entered");
                number = this.AskUserforNumbers();
            }

            return number;
        }
    }
}
