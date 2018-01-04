using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // paprasīt lietotājam ievadīt tekstu
            Console.WriteLine("Please write any combinations of letters, program will generate all possible words from those letters");
            string inputAsText = Console.ReadLine();

            // iegūt no ievadītā teksta visus unikālos burtus
            // izveidot mainīgo, kurā glabāsim tekstu, kas saturēs unikālos burtus
            string UniqueLetters = new string(inputAsText.Distinct().ToArray());


            // ciklā iet cauri lietotāja ievadītajam tekstam pa vienam burtam
            // ja šis burts neatrodas mūsu izveidotajā unikālo burtu teksta mainīgajā, tad pievienot šo burtu šim teksta mainīgajam
            // kad viss teksts apskatīts, atgriezt rezultāta teksta mainīgo ar unikālajiem burtiem


            // nolasīt visus vārdus no faila, ierakstot tos sarakstā, kur katrs ieraksts ir viens vārds
            string[] Lines = System.IO.File.ReadAllLines(@"Words.txt");
            // iet cauri šobrīdējam vārdam no faila pa vienam simbolam

            foreach (string line in Lines)

            {
                bool LetterFound = true;

                foreach (char LineLetters in line)
                {

                    // pārbaudīt, vai šis simbols atrodas mūsu unikālo burtu tekstā
                    if (UniqueLetters.Contains(LineLetters) == false)
                    {
                        // ja simbols neatrodas starp unikālajiem simboliem, tad pārstāt iet cauri šim vārdam pa simboliem
                        LetterFound = false;
                        break;

                    }



                }

                if (LetterFound == true)
                {
                    Console.WriteLine(line);
                }


            }


            Console.ReadLine();

            // ja visi simboli no vārda atrodas unikālo simbolu virknē un visi unikālie simboli atrodas vārdā, izvadīt to uz ekrāna


        }
    }
}