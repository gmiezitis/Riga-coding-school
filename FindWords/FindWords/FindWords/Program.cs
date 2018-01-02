using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWords
{
    using System.Collections.ObjectModel;
    using System.IO;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet vārdu");
            Console.ReadLine();
        }
         
       {
            var uniqueLetters = inputAsText.Distinct().ToArray();

        string[] Lines = System.IO.File.ReadAllLines(@"C:\Users\dzene\source\repos\Riga-coding-school\FindWords\FindWords\words.txt");
            foreach(string wordFromFile in Lines)
            
            {
                bool missingLetterFound = false;
                foreach (char letterFromFileWord in wordFromFile) ;
                {
                    if (uniqueLetters.Contains(letterFromFileWord) == false) ;
                    {
                        missingLetterFound = true;
                        break;
            

                    
                
                
                 if(missingLetterFound == false)
                {
                    Console.WriteLine(wordFromFile);
                }



        }
    }
}
